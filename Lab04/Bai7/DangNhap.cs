using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http; 

namespace Bai7
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            TB_Password.UseSystemPasswordChar = true;
        }

        private void LLB_SIGNUP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            this.Hide();
            dangKy.Show();
        }

        private async void BTN_Login_Click(object sender, EventArgs e)
        {
            string username = TB_Username.Text;
            string password = TB_Password.Text;
            if (username == "")
            {
                MessageBox.Show("Username không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Password không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Password không được nhỏ hơn 8 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string url = "https://nt106.uitiot.vn/auth/token";
            var formData = new List<KeyValuePair<string, string>>();
            formData.Add(new KeyValuePair<string, string>("username", username));
            formData.Add(new KeyValuePair<string, string>("password", password));

            try
            {
                HttpClient client = new HttpClient();
                HttpContent content = new FormUrlEncodedContent(formData);
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    JObject data = JObject.Parse(responseString);
                    string token = data["access_token"].ToString();
                    this.Hide();
                    HomNayAnGi hnag = new HomNayAnGi(token,username);
                    hnag.Show();
                }
                else
                {
                    JObject error = JObject.Parse(responseString);
                    string message;
                    if (error["detail"] != null)
                    {
                        message = error["detail"].ToString();
                    }
                    else
                    {
                        message = responseString;
                    }

                    MessageBox.Show("Đăng nhập thất bại: " + message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}