using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai04
{
    public partial class Bai04_Client : Form
    {
        TcpClient tcp;
        NetworkStream netStream;
        StreamReader netReader;
        StreamWriter netWriter;
        CancellationTokenSource cts;
        string clientId = Guid.NewGuid().ToString();

        List<TabPage> allTabs = new List<TabPage>();
        Dictionary<string, Movie> movies = new Dictionary<string, Movie>();
        HashSet<string> soldSeats = new HashSet<string>();

        public Bai04_Client()
        {
            InitializeComponent();

            foreach (TabPage tab in tabControl1.TabPages)
                allTabs.Add(tab);

            foreach (TabPage tab in tabControl1.TabPages)
                foreach (CheckBox cb in tab.Controls.OfType<CheckBox>())
                    cb.CheckedChanged += Ghe_CheckedChanged;

            cbFilm.SelectedIndexChanged += cbFilm_SelectedIndexChanged;
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            await ConnectToServerAsync("127.0.0.1", 5000);
        }

        private async Task ConnectToServerAsync(string host, int port)
        {
            try
            {
                tcp = new TcpClient();
                await tcp.ConnectAsync(host, port);
                netStream = tcp.GetStream();
                netReader = new StreamReader(netStream, Encoding.UTF8);
                netWriter = new StreamWriter(netStream) { AutoFlush = true };
                cts = new CancellationTokenSource();

                var initMsg = new { Type = "InitRequest", Payload = new { ClientId = clientId } };
                await netWriter.WriteLineAsync(JsonSerializer.Serialize(initMsg));

                string line = await netReader.ReadLineAsync();
                var msg = JsonSerializer.Deserialize<Message>(line);

                if (msg.Type == "InitResponse")
                {
                    movies.Clear();
                    var moviesElement = msg.Payload.GetProperty("Movies");
                    foreach (var prop in moviesElement.EnumerateObject())
                    {
                        string name = prop.Name;
                        var mv = JsonSerializer.Deserialize<Movie>(prop.Value.GetRawText());
                        movies[name] = mv;
                    }

                    soldSeats.Clear();
                    foreach (var s in msg.Payload.GetProperty("SoldSeats").EnumerateArray())
                        soldSeats.Add(s.GetString());

                    this.Invoke((Action)(() =>
                    {
                        cbFilm.DataSource = null;
                        cbFilm.DataSource = movies.Keys.ToList();
                        cbFilm.SelectedIndex = -1;
                        MessageBox.Show("Kết nối server thành công!");
                    }));
                }

                _ = Task.Run(() => ReceiveLoopAsync(cts.Token));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối server: " + ex.Message);
            }
        }

        private async Task ReceiveLoopAsync(CancellationToken token)
        {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    string line = await netReader.ReadLineAsync();
                    if (line == null) break;

                    var msg = JsonSerializer.Deserialize<Message>(line);

                    if (msg.Type == "SeatUpdate")
                    {
                        string key = msg.Payload.GetProperty("SeatKey").GetString();
                        bool sold = msg.Payload.GetProperty("Sold").GetBoolean();

                        if (sold) soldSeats.Add(key);
                        else soldSeats.Remove(key);

                        this.Invoke((Action)(() =>
                        {
                            foreach (TabPage tab in tabControl1.TabPages)
                            {
                                foreach (CheckBox cb in tab.Controls.OfType<CheckBox>())
                                {
                                    string seatKey = $"{tab.Text}-{cb.Text}";
                                    if (seatKey == key)
                                    {
                                        cb.Checked = false;
                                        cb.Enabled = !sold;
                                    }
                                }
                            }
                        }));
                    }
                    else if (msg.Type == "BookResult")
                    {
                        bool success = msg.Payload.GetProperty("Success").GetBoolean();
                        string reason = msg.Payload.GetProperty("Reason").GetString();

                        this.Invoke((Action)(() =>
                        {
                            if (success)
                                MessageBox.Show("Thanh toán thành công!");
                            else
                                MessageBox.Show("Thanh toán thất bại: " + reason);
                        }));
                    }
                }
            }
            catch { }
        }

        private void cbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilm.SelectedItem == null) return;
            string movieName = cbFilm.SelectedItem.ToString();
            if (!movies.ContainsKey(movieName)) return;

            var mv = movies[movieName];

            tabControl1.TabPages.Clear();

            foreach (int r in mv.Rooms)
            {
                if (r - 1 >= 0 && r - 1 < allTabs.Count)
                {
                    tabControl1.TabPages.Add(allTabs[r - 1]);
                    foreach (CheckBox cb in allTabs[r - 1].Controls.OfType<CheckBox>())
                    {
                        int roomIndex = r;
                        string key = $"{roomIndex}-{cb.Text}";
                        cb.Checked = false;
                        cb.Enabled = !soldSeats.Contains(key);
                    }
                }
            }
        }

        private void Ghe_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb == null || !cb.Checked) return;

            TabPage tab = cb.Parent as TabPage;
            int roomIndex = allTabs.IndexOf(tab) + 1;
            string key = $"{roomIndex}-{cb.Text}";

            if (soldSeats.Contains(key))
            {
                cb.Checked = false;
                MessageBox.Show("Ghế đã được đặt ở quầy khác!");
            }
        }

        private async void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!");
                return;
            }

            string movieName = cbFilm.SelectedItem?.ToString();
            if (movieName == null)
            {
                MessageBox.Show("Vui lòng chọn phim!");
                return;
            }

            var gheDaChon = new List<(int room, string seat)>();
            foreach (TabPage tab in tabControl1.TabPages)
            {
                int roomIndex = allTabs.IndexOf(tab) + 1;
                foreach (CheckBox cb in tab.Controls.OfType<CheckBox>())
                {
                    if (cb.Checked)
                        gheDaChon.Add((roomIndex, cb.Text));
                }
            }

            if (!gheDaChon.Any())
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!");
                return;
            }

            double tongTien = 0;
            foreach (var g in gheDaChon)
            {
                double price = movies[movieName].BasePrice;
                if (new[] { "A1", "A5", "C1", "C5" }.Contains(g.seat))
                    price *= 0.25;
                else if (new[] { "B2", "B3", "B4" }.Contains(g.seat))
                    price *= 2;

                tongTien += price;
            }

            string msgBoxText = $"Khách hàng: {tbName.Text}\nPhim: {movieName}\n" +
                                $"Ghế: {string.Join(", ", gheDaChon.Select(x => $"P{x.room}-{x.seat}"))}\n" +
                                $"Tổng tiền: {tongTien:#,##0}đ";
            MessageBox.Show(msgBoxText, "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (var g in gheDaChon)
            {
                var tab = tabControl1.TabPages.Cast<TabPage>().FirstOrDefault(t => allTabs.IndexOf(t) + 1 == g.room);
                if (tab != null)
                {
                    var cb = tab.Controls.OfType<CheckBox>().FirstOrDefault(c => c.Text == g.seat);
                    if (cb != null)
                    {
                        cb.Enabled = false;
                        cb.Checked = false;
                    }
                }
                soldSeats.Add($"{g.room}-{g.seat}");
            }

            var payload = new
            {
                Movie = movieName,
                ClientId = clientId,
                Seats = gheDaChon.Select(g => new { g.room, g.seat }).ToList()
            };
            var msg = new { Type = "BookRequest", Payload = payload };
            await netWriter.WriteLineAsync(JsonSerializer.Serialize(msg));
        }

        class Message
        {
            public string Type { get; set; }
            public JsonElement Payload { get; set; }
        }

        public class Movie
        {
            public string Name { get; set; }
            public double BasePrice { get; set; }
            public List<int> Rooms { get; set; } = new List<int>();
        }
    }
}
