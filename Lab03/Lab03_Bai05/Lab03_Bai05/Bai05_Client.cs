using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Lab03_Bai05
{
    public partial class Bai05_Client : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private CancellationTokenSource cts = new CancellationTokenSource();

        private string username;
        private string defaultIP = "127.0.0.1";
        private int defaultPort = 8081; // cổng theo bài 5

        public Bai05_Client()
        {
            InitializeComponent();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            username = tbNameUser.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng!");
                return;
            }

            try
            {
                client = new TcpClient();
                await client.ConnectAsync(defaultIP, defaultPort);

                NetworkStream ns = client.GetStream();
                reader = new StreamReader(ns, Encoding.UTF8);
                writer = new StreamWriter(ns, Encoding.UTF8) { AutoFlush = true };

                rtbOut.AppendText("✅ Đã kết nối đến server!\n");
                btnConnect.Enabled = false;

                _ = Task.Run(() => ListenServerAsync(cts.Token));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối server: {ex.Message}");
            }
        }

        private async Task ListenServerAsync(CancellationToken token)
        {
            try
            {
                while (!token.IsCancellationRequested && client?.Connected == true)
                {
                    string msg = await reader.ReadLineAsync();
                    if (msg == null) break;

                    Invoke(new Action(() => HandleServerMessage(msg)));
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    rtbOut.AppendText($"⚠️ Mất kết nối với server: {ex.Message}\n");
                    btnConnect.Enabled = true;
                }));
            }
        }

        private void HandleServerMessage(string msg)
        {
            // Các lệnh từ server: NEW_FOOD, SHOW_FOOD, ERROR
            string[] parts = msg.Split(':');
            string command = parts[0];

            if (command == "NEW_FOOD")
            {
                if (parts.Length >= 4)
                {
                    string tenMon = parts[2];
                    string nguoiThem = parts[3];
                    rtbOut.AppendText($"🍽️ {nguoiThem} đã thêm món: {tenMon}\n");
                }
            }
            else if (command == "SHOW_FOOD")
            {
                if (parts.Length >= 4)
                {
                    string tenMon = parts[1];
                    string nguoiThem = parts[3];
                    rtbOut.AppendText($"🎲 Gợi ý: {tenMon} (bởi {nguoiThem})\n");
                }
            }
            else if (command == "ERROR")
            {
                if (parts.Length > 1)
                    MessageBox.Show(parts[1], "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAddDish_Click(object sender, EventArgs e)
        {
            if (writer == null)
            {
                MessageBox.Show("Bạn chưa kết nối server!");
                return;
            }

            string tenMon = tbNameDish.Text.Trim();

            if (string.IsNullOrEmpty(tenMon))
            {
                MessageBox.Show("Nhập tên món!");
                return;
            }

            await writer.WriteLineAsync($"ADD_FOOD:{username}:{tenMon}");
            rtbOut.AppendText($"➡️ Gửi lên server: ADD_FOOD:{username}:{tenMon}\n");
            tbNameDish.Clear();
        }

        private async void btnRand_Click(object sender, EventArgs e)
        {
            if (writer == null)
            {
                MessageBox.Show("Chưa kết nối server!");
                return;
            }

            await writer.WriteLineAsync($"GET_RANDOM_MINE:{username}");
        }

        private async void btnRandAll_Click(object sender, EventArgs e)
        {
            if (writer == null)
            {
                MessageBox.Show("Chưa kết nối server!");
                return;
            }

            await writer.WriteLineAsync("GET_RANDOM_ALL");
        }
    }
}
