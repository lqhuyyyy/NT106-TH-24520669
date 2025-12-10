using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetInfo_Click(object sender, EventArgs e)
        {
            string url = "https://nt106.uitiot.vn/api/v1/user/me";
            MultipartFormDataContent content = new MultipartFormDataContent();
            content.Add(new StringContent("huyphuoc1"), "username");
            content.Add(new StringContent("Phuoc_2005"), "password");
            HttpClient client = new HttpClient();
            HttpResponseMessage responsedangnhap = await client.PostAsync("https://nt106.uitiot.vn/auth/token", content);

            string responseStringlogin = await responsedangnhap.Content.ReadAsStringAsync();

            JObject responseObject = JObject.Parse(responseStringlogin);

            string accessToken = responseObject["access_token"].ToString();

            if (string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show("Bạn chưa đăng nhập hoặc chưa có Token!");
                return;
            }

            try
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                HttpResponseMessage response = await client.GetAsync(url);

                string responseString = await response.Content.ReadAsStringAsync();
                rtbLog.AppendText("\t          KẾT QUẢ GET:        \n");
                rtbLog.AppendText(responseString);
            }
            catch (Exception ex)
            {
                rtbLog.Text += "\nLỗi: " + ex.Message;
            }

        }
    }
}