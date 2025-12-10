using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;

namespace Bai5
{
    public partial class Form1 : Form
    {
        string strConnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=Lab5_MonAn;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDuyetMail_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập Email và Password!");
                return;
            }

            try
            {
                using (var client = new ImapClient())
                {
                    // Kết nối IMAP
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(email, password);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadWrite);

                    // Lọc mail: Tiêu đề chứa "Đóng góp món ăn" và Chưa đọc
                    var query = SearchQuery.SubjectContains("Đóng góp món ăn").And(SearchQuery.NotSeen);
                    var uids = inbox.Search(query);

                    int count = 0;

                    // Tạo thư mục "Images" để lưu ảnh tải về nếu chưa có
                    string folderPath = Path.Combine(Application.StartupPath, "Images");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    using (SqlConnection sqlConn = new SqlConnection(strConnect))
                    {
                        sqlConn.Open();

                        foreach (var uid in uids)
                        {
                            var message = inbox.GetMessage(uid);

                            // 1. Lấy Tên món ăn từ Body (Giả sử nội dung mail chỉ ghi tên món)
                            string tenMon = message.TextBody?.Trim();

                            // 2. Xử lý File đính kèm (Attachment)
                            string duongDanAnh = ""; // Biến lưu đường dẫn file trên máy

                            // Kiểm tra xem mail có đính kèm file nào không
                            if (message.Attachments.Any())
                            {
                                // Lấy file đính kèm đầu tiên
                                var attachment = message.Attachments.FirstOrDefault() as MimePart;

                                if (attachment != null && !string.IsNullOrEmpty(tenMon))
                                {
                                    // Tạo tên file ngẫu nhiên để tránh trùng (dùng GUID)
                                    string fileName = $"{Guid.NewGuid()}_{attachment.FileName}";
                                    string savePath = Path.Combine(folderPath, fileName);

                                    // Lưu file ảnh xuống ổ cứng
                                    using (var stream = File.Create(savePath))
                                    {
                                        attachment.Content.DecodeTo(stream);
                                    }

                                    duongDanAnh = savePath; // Lưu đường dẫn tuyệt đối để tí lưu vào SQL
                                }
                            }

                            // 3. Nếu có đủ Tên món và Ảnh -> Lưu vào SQL
                            if (!string.IsNullOrEmpty(tenMon) && !string.IsNullOrEmpty(duongDanAnh))
                            {
                                string nguoiDongGop = "Người ẩn danh";
                                if (message.From.Count > 0)
                                    nguoiDongGop = message.From[0].Name ?? message.From[0].ToString();

                                string sqlInsert = "INSERT INTO MonAn (TenMon, HinhAnh, NguoiDongGop) VALUES (@Ten, @Hinh, @Nguoi)";
                                using (SqlCommand cmd = new SqlCommand(sqlInsert, sqlConn))
                                {
                                    cmd.Parameters.AddWithValue("@Ten", tenMon);
                                    cmd.Parameters.AddWithValue("@Hinh", duongDanAnh); // Lưu đường dẫn file local
                                    cmd.Parameters.AddWithValue("@Nguoi", nguoiDongGop);
                                    cmd.ExecuteNonQuery();
                                }

                                count++;
                            }

                            // Đánh dấu đã đọc để không tải lại
                            inbox.AddFlags(uid, MessageFlags.Seen, true);
                        }
                    }

                    client.Disconnect(true);
                    MessageBox.Show($"Đã tải về và thêm thành công {count} món ăn (kèm ảnh)!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // CHỨC NĂNG 2: RANDOM MÓN ĂN
        private void btnRandom_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(strConnect))
                {
                    sqlConn.Open();
                    // Lấy ngẫu nhiên 1 món
                    string sqlRandom = "SELECT TOP 1 TenMon, HinhAnh, NguoiDongGop FROM MonAn ORDER BY NEWID()";

                    using (SqlCommand cmd = new SqlCommand(sqlRandom, sqlConn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string tenMon = reader["TenMon"].ToString();
                                string linkAnh = reader["HinhAnh"].ToString(); // Đây là đường dẫn file trên máy
                                string nguoi = reader["NguoiDongGop"].ToString();

                                lblTenMon.Text = tenMon;
                                lblContributor.Text = "Đóng góp bởi: " + nguoi;

                                // Load ảnh từ File trên máy
                                if (File.Exists(linkAnh))
                                {
                                    // Cách load này giúp tránh lỗi file bị khóa (Lock)
                                    using (FileStream fs = new FileStream(linkAnh, FileMode.Open, FileAccess.Read))
                                    {
                                        pictureBox1.Image = System.Drawing.Image.FromStream(fs);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ảnh món này đã bị xóa hoặc không tồn tại!");
                                    pictureBox1.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kho dữ liệu trống!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}