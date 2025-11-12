using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab03_Bai04.Bai04_Client;

namespace Lab03_Bai04
{
    public partial class Bai04_Sever : Form
    {
        private TcpListener listener;
        private List<TcpClient> clients = new List<TcpClient>();
        private Dictionary<string, Movie> movies = new Dictionary<string, Movie>();
        private HashSet<string> soldSeats = new HashSet<string>();
        public Bai04_Sever()
        {
            InitializeComponent();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            LoadMoviesFromFile(@"E:\NT106-TH-24520669\Lab03\Lab03_Bai04\Lab03_Bai04\movies.txt");
            StartServerAsync();
        }
        private void LoadMoviesFromFile(string path)
        {
            movies.Clear();

            if (!File.Exists(path))
            {
                rtb_Out.AppendText("File movies.txt không tồn tại!\r\n");
                return;
            }

            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i += 3)
            {
                string name = lines[i].Trim();
                if (string.IsNullOrEmpty(name)) continue;

                double price = double.Parse(lines[i + 1]);
                List<int> rooms = lines[i + 2].Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                              .Select(int.Parse).ToList();

                movies[name] = new Movie
                {
                    Name = name,
                    BasePrice = price,
                    Rooms = rooms
                };
            }

            rtb_Out.AppendText($"Đã nạp {movies.Count} phim từ file.\r\n");
        }

        private async void StartServerAsync()
        {
            listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();
            rtb_Out.AppendText("Server đang chạy...\r\n");

            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                clients.Add(client);
                rtb_Out.AppendText($"Client connected: {client.Client.RemoteEndPoint}\r\n");
                _ = Task.Run(() => HandleClientAsync(client));
            }
        }

        private async Task HandleClientAsync(TcpClient tcp)
        {
            var reader = new StreamReader(tcp.GetStream(), Encoding.UTF8);
            var writer = new StreamWriter(tcp.GetStream(), Encoding.UTF8) { AutoFlush = true };

            try
            {
                while (true)
                {
                    string line = await reader.ReadLineAsync();
                    if (line == null) break;

                    var msg = JsonSerializer.Deserialize<Message>(line);

                    switch (msg.Type)
                    {
                        case "InitRequest":
                            var payload = new
                            {
                                Movies = movies,
                                SoldSeats = soldSeats.ToList()
                            };
                            var resp = new { Type = "InitResponse", Payload = payload };
                            await writer.WriteLineAsync(JsonSerializer.Serialize(resp));
                            break;

                        case "BookRequest":
                            string movieName = msg.Payload.GetProperty("Movie").GetString();
                            var seats = msg.Payload.GetProperty("Seats").EnumerateArray()
                                .Select(s => new
                                {
                                    Room = s.GetProperty("room").GetInt32(),
                                    Seat = s.GetProperty("seat").GetString()
                                }).ToList();

                            bool conflict = seats.Any(s => soldSeats.Contains($"{s.Room}-{s.Seat}"));

                            if (conflict)
                            {
                                var failResp = new
                                {
                                    Type = "BookResult",
                                    Payload = new { Success = false, Reason = "Ghế đã được đặt" }
                                };
                                await writer.WriteLineAsync(JsonSerializer.Serialize(failResp));
                            }
                            else
                            {
                                foreach (var s in seats)
                                    soldSeats.Add($"{s.Room}-{s.Seat}");

                                var successResp = new
                                {
                                    Type = "BookResult",
                                    Payload = new { Success = true, Reason = "" }
                                };
                                await writer.WriteLineAsync(JsonSerializer.Serialize(successResp));

                                foreach (var c in clients)
                                {
                                    if (c == tcp) continue; 
                                    var w = new StreamWriter(c.GetStream(), Encoding.UTF8) { AutoFlush = true };
                                    foreach (var s in seats)
                                    {
                                        var seatMsg = new
                                        {
                                            Type = "SeatUpdate",
                                            Payload = new
                                            {
                                                SeatKey = $"{s.Room}-{s.Seat}",
                                                Sold = true
                                            }
                                        };
                                        await w.WriteLineAsync(JsonSerializer.Serialize(seatMsg));
                                    }
                                }
                            }
                            break;
                    }
                }
            }
            catch { }
            finally
            {
                clients.Remove(tcp);
                tcp.Close();
            }
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
