using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void BTN_Download_Click(object sender, EventArgs e)
        {
            RTB_html.Clear();
            string link = TB_Web.Text.Trim();
            string luu = TB_Save.Text.Trim();
            if (string.IsNullOrEmpty(link))
            {
                MessageBox.Show("Vui lòng nhập link.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(luu))
            {
                MessageBox.Show("Vui lòng nhập đường dẫn lưu file.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!link.StartsWith("http://") && !link.StartsWith("https://"))
            {
                link = "http://" + link;
                TB_Web.Text = link;
            }
            WebClient myClient = new WebClient();

            try
            {
                string directory = Path.GetDirectoryName(luu);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                myClient.DownloadFile(link, luu);
                RTB_html.Text = File.ReadAllText(luu);

                MessageBox.Show("Tải về thành công!\nĐã lưu tại: " + luu, "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (WebException webEx)
            {
                MessageBox.Show("Lỗi mạng hoặc link không hợp lệ: \n" + webEx.Message, "Lỗi Tải File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
