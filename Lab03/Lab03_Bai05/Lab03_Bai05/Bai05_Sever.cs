using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab03_Bai05
{
    public partial class Bai05_Sever : Form
    {
        TcpListener server;
        Thread listenThread;
        readonly List<TcpClient> clients = new List<TcpClient>();

        readonly string connectionString = "Data Source=ServerBai05.db;Version=3;";
        readonly string serverIP = "127.0.0.1";
        readonly int serverPort = 8081;

        readonly object dbLock = new object();

        public Bai05_Sever()
        {
            InitializeComponent();
        }

        private void Bai05_Sever_Load(object sender, EventArgs e)
        {
            InitDatabase();
        }

        private void InitDatabase()
        {
            string realPath = System.IO.Path.GetFullPath("ServerBai05.db");
            rtb_Out.AppendText("DB file: " + realPath + "\n");
            try
            {
                if (!System.IO.File.Exists("ServerBai05.db"))
                {
                    SQLiteConnection.CreateFile("ServerBai05.db");
                }

                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"CREATE TABLE IF NOT EXISTS MonAn (
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    NguoiDung TEXT NOT NULL,
                                    TenMon TEXT NOT NULL,
                                    Anh TEXT
                                   );";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                rtb_Out.AppendText("✅ Database đã sẵn sàng.\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo database: " + ex.Message);
            }
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            try
            {
                server = new TcpListener(IPAddress.Parse(serverIP), serverPort);
                server.Start();

                listenThread = new Thread(ListenClients);
                listenThread.IsBackground = true;
                listenThread.Start();

                rtb_Out.AppendText($"✅ Server chạy tại {serverIP}:{serverPort}\n");
                btn_Listen.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể khởi động server: " + ex.Message);
            }
        }

        private void ListenClients()
        {
            while (true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    clients.Add(client);

                    rtb_Out.Invoke((MethodInvoker)(() =>
                    {
                        rtb_Out.AppendText("🔗 Client mới đã kết nối.\n");
                    }));

                    Thread clientThread = new Thread(() => HandleClient(client));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
                catch
                {
                    break;
                }
            }
        }
        private void HandleClient(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            byte[] buffer = new byte[2048];

            while (true)
            {
                try
                {
                    int bytes = ns.Read(buffer, 0, buffer.Length);
                    if (bytes == 0)
                        break;

                    string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
                    string[] parts = msg.Split('|');

                    if (msg.StartsWith("RANDOM_SELF"))
                    {
                        string user = parts.Length > 1 ? parts[1] : "";
                        string dish = GetRandomDishOfUser(user);

                        SendToOne(client, $"🎲 Món ngẫu nhiên của bạn: {dish}");
                        continue;
                    }

                    if (msg.StartsWith("RANDOM_ALL"))
                    {
                        string dish = GetRandomDishAll();
                        SendToOne(client, $"🌍 Món ngẫu nhiên cộng đồng: {dish}");
                        continue;
                    }

                    if (parts.Length >= 3)
                    {
                        string user = parts[0];
                        string name = parts[1];
                        string pic = parts[2];

                        SaveDish(user, name, pic);

                        string fullMsg = $"🍽 {user} đã thêm món mới: {name}";
                        Broadcast(fullMsg);

                        rtb_Out.Invoke((MethodInvoker)(() =>
                        {
                            rtb_Out.AppendText(fullMsg + "\n");
                        }));
                    }
                }
                catch
                {
                    break;
                }
            }

            clients.Remove(client);
            client.Close();
        }
        private void SaveDish(string user, string name, string pic)
        {
            try
            {
                lock (dbLock)
                {
                    using (var conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        string sql = "INSERT INTO MonAn (NguoiDung, TenMon, Anh) VALUES (@u, @m, @a)";
                        using (var cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@u", user);
                            cmd.Parameters.AddWithValue("@m", name);
                            cmd.Parameters.AddWithValue("@a", pic);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                rtb_Out.Invoke((MethodInvoker)(() =>
                {
                    rtb_Out.AppendText("⚠ Lỗi lưu dữ liệu vào CSDL: " + ex.Message + "\n");
                }));
            }
        }
        private string GetRandomDishOfUser(string user)
        {
            try
            {
                lock (dbLock)
                {
                    using (var conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        string sql = "SELECT TenMon FROM MonAn WHERE NguoiDung=@u ORDER BY RANDOM() LIMIT 1";

                        using (var cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@u", user);
                            var result = cmd.ExecuteScalar();
                            return result?.ToString() ?? "Bạn chưa có món nào!";
                        }
                    }
                }
            }
            catch
            {
                return "Lỗi khi lấy món!";
            }
        }
        private string GetRandomDishAll()
        {
            try
            {
                lock (dbLock)
                {
                    using (var conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        string sql = "SELECT TenMon FROM MonAn ORDER BY RANDOM() LIMIT 1";

                        using (var cmd = new SQLiteCommand(sql, conn))
                        {
                            var result = cmd.ExecuteScalar();
                            return result?.ToString() ?? "Chưa có món nào!";
                        }
                    }
                }
            }
            catch
            {
                return "Lỗi khi lấy món!";
            }
        }

        private void SendToOne(TcpClient client, string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                client.GetStream().Write(data, 0, data.Length);
            }
            catch { }
        }

        private void Broadcast(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);

            List<TcpClient> dead = new List<TcpClient>();

            foreach (var c in clients)
            {
                try
                {
                    c.GetStream().Write(data, 0, data.Length);
                }
                catch
                {
                    dead.Add(c);
                }
            }

            foreach (var d in dead)
            {
                clients.Remove(d);
                try { d.Close(); } catch { }
            }
        }
    }
}
