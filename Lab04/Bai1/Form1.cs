using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getHTML(string szURL)
        {
            if (string.IsNullOrWhiteSpace(szURL))
                return string.Empty;

            try
            {
                if (!szURL.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && !szURL.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                {
                    szURL = "http://" + szURL;
                }

                WebRequest request = WebRequest.Create(szURL);

                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream ?? Stream.Null, Encoding.UTF8))
                {
                    string responseFromServer = reader.ReadToEnd();
                    return responseFromServer;
                }
            }
            catch (WebException ex)
            {
                return $"LỖI KẾT NỐI (WebException): {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"LỖI: {ex.Message}";
            }
        }

        private void btnGetHTML_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                rtbHTMLContent.Text = "Vui lòng nhập URL hợp lệ.";
                return;
            }

            string htmlContent = getHTML(url);
            rtbHTMLContent.Text = htmlContent;
        }
    }
}