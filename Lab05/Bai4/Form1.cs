using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public class Film
        {
            public string TenPhim { get; set; }
            public string PosterUrl { get; set; }
        }

        private List<Film> danhSachPhim;
        private readonly List<string> gheDaChon = new List<string>();
        private const string SLOGAN = "Chúc bạn có những giây phút thư giãn tuyệt vời tại Rạp!";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaoDanhSachPhim();
            TaoSoDoGhe();

            cboPhim.DataSource = danhSachPhim;
            cboPhim.DisplayMember = "TenPhim";
            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;

            if (danhSachPhim.Count > 0)
                HienThiPoster(danhSachPhim[0].PosterUrl);
        }

        private void TaoDanhSachPhim()
        {
            danhSachPhim = new List<Film>
            {
                new Film { TenPhim = "Avengers: Endgame", PosterUrl = @"C:\Images\Avengers_Endgame.jpg" },
                new Film { TenPhim = "Inception", PosterUrl = @"C:\Images\Inception.jpg" },
                new Film { TenPhim = "Interstellar", PosterUrl = @"C:\Images\Interstellar.jpg" },
                new Film { TenPhim = "Spider-Man: No Way Home", PosterUrl = @"C:\Images\SpiderMan.jpg" },
                new Film { TenPhim = "The Dark Knight", PosterUrl = @"C:\Images\DarkKnight.jpg" },
                new Film { TenPhim = "Your Name", PosterUrl = @"C:\Images\YourName.jpg" },
                new Film { TenPhim = "Doraemon: Nobita và Vũ Trụ", PosterUrl = @"C:\Images\Doraemon.jpg" }
            };
        }

        private void TaoSoDoGhe()
        {
            int rows = 5, cols = 8, size = 38, margin = 5;
            pnlSoDoGhe.Controls.Clear();
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    string tenGhe = $"{(char)('A' + r)}{c + 1}";
                    Button btn = new Button
                    {
                        Text = tenGhe,
                        Tag = tenGhe,
                        Size = new Size(size, size),
                        Location = new Point(c * (size + margin), r * (size + margin)),
                        BackColor = Color.LightGray
                    };
                    btn.Click += BtnChonGhe;
                    pnlSoDoGhe.Controls.Add(btn);
                }
            }
        }

        private void BtnChonGhe(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string tenGhe = btn.Tag.ToString();
            if (gheDaChon.Contains(tenGhe))
            {
                gheDaChon.Remove(tenGhe);
                btn.BackColor = Color.LightGray;
            }
            else
            {
                gheDaChon.Add(tenGhe);
                btn.BackColor = Color.MediumSeaGreen;
            }
            gheDaChon.Sort();
            txtGhDaChon.Text = string.Join(", ", gheDaChon);
        }

        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film selectedFilm = cboPhim.SelectedItem as Film;
            if (selectedFilm != null)
                HienThiPoster(selectedFilm.PosterUrl);
        }

        private void HienThiPoster(string url)
        {
            try
            {
                pbPoster.Image = string.IsNullOrEmpty(url) ? null : Image.FromFile(url);
            }
            catch { pbPoster.Image = null; }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            string senderEmail = txtSenderEmail.Text.Trim();
            string senderPassword = txtSenderPassword.Text.Trim();
            string recipientEmail = txtEmail.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string ghe = txtGhDaChon.Text.Trim();
            Film f = cboPhim.SelectedItem as Film;

            if (string.IsNullOrEmpty(senderEmail) || string.IsNullOrEmpty(senderPassword) ||
                string.IsNullOrEmpty(recipientEmail) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(ghe))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (f == null)
            {
                MessageBox.Show("Vui lòng chọn phim!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GuiEmail(senderEmail, senderPassword, recipientEmail, hoTen, f.TenPhim, ghe, f.PosterUrl);
        }

        private void GuiEmail(string senderEmail, string senderPassword, string recipientEmail,
            string hoTen, string tenPhim, string ghe, string posterPath)
        {
            lblTrangThai.Text = "Đang gửi email...";
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(senderEmail, senderPassword)
                };

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(senderEmail, "Rạp ABC"),
                    Subject = $"Xác nhận đặt vé - {tenPhim}",
                    IsBodyHtml = true
                };
                mail.To.Add(recipientEmail);

                string htmlBody = $@"
                    <h2>VÉ ĐIỆN TỬ</h2>
                    <p>Xin chào <b>{hoTen}</b>,</p>
                    <p>Bạn đã đặt vé thành công:</p>
                    <ul>
                        <li>Phim: <b>{tenPhim}</b></li>
                        <li>Ghế: <b>{ghe}</b></li>
                    </ul>
                    <p>{SLOGAN}</p>
                    {(System.IO.File.Exists(posterPath) ? "<img src='cid:posterImage' width='300'/>" : "")}";

                AlternateView av = AlternateView.CreateAlternateViewFromString(htmlBody, null, "text/html");
                if (System.IO.File.Exists(posterPath))
                {
                    LinkedResource posterResource = new LinkedResource(posterPath);
                    posterResource.ContentId = "posterImage";
                    posterResource.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;
                    av.LinkedResources.Add(posterResource);
                }

                mail.AlternateViews.Add(av);
                client.Send(mail);

                lblTrangThai.Text = "Đã gửi email thành công!";
                MessageBox.Show("Email xác nhận đã được gửi.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Gửi email thất bại!";
                MessageBox.Show("Lỗi gửi email: " + ex.Message, "Lỗi Gửi Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
