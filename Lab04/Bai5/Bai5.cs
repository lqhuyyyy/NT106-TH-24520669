using Newtonsoft.Json.Linq; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    MultipartFormDataContent content = new MultipartFormDataContent();
                    content.Add(new StringContent(username), "username");
                    content.Add(new StringContent(password), "password");

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    string responseString = await response.Content.ReadAsStringAsync();

                    JObject responseObject = JObject.Parse(responseString);

                    rtbResponse.Clear();

                    if (response.IsSuccessStatusCode)
                    {
                        string tokenType = responseObject["token_type"].ToString();
                        string accessToken = responseObject["access_token"].ToString();

                        rtbResponse.Text += $"{tokenType} {accessToken}\n";
                        rtbResponse.Text += "\nĐăng nhập thành công";
                    }
                    else
                    {
                        string detail = responseObject["detail"].ToString();
                        rtbResponse.Text += detail;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}