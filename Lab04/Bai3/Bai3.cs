using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private string GetAbsoluteUrl(string baseUrl, string relativeUrl)
        {
            try
            {
                Uri absoluteUri = new Uri(new Uri(baseUrl), relativeUrl);
                return absoluteUri.AbsoluteUri;
            }
            catch
            {
                return null;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string url = txtURL_B3.Text.Trim();
            if (string.IsNullOrEmpty(url)) return;

            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                url = "http://" + url;
            }

            try
            {
                webView.Navigate(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trang: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownloadHTML_Click(object sender, EventArgs e)
        {
            string url = txtURL_B3.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL trước.");
                return;
            }

            using (SaveFileDialog saveDlg = new SaveFileDialog())
            {
                saveDlg.Filter = "HTML File (*.html)|*.html|All files (*.*)|*.*";
                saveDlg.DefaultExt = "html";
                saveDlg.FileName = "downloaded_page.html";

                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (WebClient myClient = new WebClient())
                        {
                            myClient.DownloadFile(url, saveDlg.FileName);
                            MessageBox.Show($"Tải file HTML thành công!\nLưu tại: {saveDlg.FileName}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDownloadResources_Click(object sender, EventArgs e)
        {
            string baseUrl = txtURL_B3.Text.Trim();
            if (string.IsNullOrEmpty(baseUrl))
            {
                MessageBox.Show("Vui lòng nhập URL trước.");
                return;
            }

            using (FolderBrowserDialog folderDlg = new FolderBrowserDialog())
            {
                if (folderDlg.ShowDialog() == DialogResult.OK)
                {
                    string savePath = folderDlg.SelectedPath;
                    int downloadCount = 0;

                    try
                    {
                        using (WebClient wc = new WebClient())
                        {
                            string htmlContent = wc.DownloadString(baseUrl);
                            var matches = Regex.Matches(htmlContent, "<img[^>]+src\\s*=\\s*['\"](?<src>[^'\"]+)['\"][^>]*>", RegexOptions.IgnoreCase);

                            foreach (Match m in matches)
                            {
                                string src = m.Groups["src"].Value;
                                if (string.IsNullOrEmpty(src)) continue;

                                string imageUrl = GetAbsoluteUrl(baseUrl, src);
                                if (imageUrl == null) continue;

                                string fileName = Path.GetFileName(new Uri(imageUrl).LocalPath);
                                if (string.IsNullOrEmpty(fileName) || fileName.Length > 255)
                                {
                                    fileName = Guid.NewGuid().ToString() + ".dat";
                                }

                                string fullSavePath = Path.Combine(savePath, fileName);

                                try
                                {
                                    wc.DownloadFile(imageUrl, fullSavePath);
                                    downloadCount++;
                                }
                                catch
                                {
                                }
                            }
                        }

                        MessageBox.Show($"Đã tải thành công {downloadCount} tài nguyên (hình ảnh) về:\n{savePath}", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi trong quá trình tải tài nguyên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
