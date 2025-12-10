using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
namespace Bai7
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            TB_Password.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TB_Email.Clear();
            TB_Firstname.Clear();
            TB_Lastname.Clear();
            TB_Password.Clear();
            TB_Phone.Clear();
            TB_Username.Clear();
            CB_Language.SelectedIndex = -1;
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            CB_Language.Items.Add("Việt Nam");
            CB_Language.Items.Add("Trung Quốc");
            CB_Language.Items.Add("Nga");
            CB_Language.Items.Add("Mỹ");
            CB_Language.Items.Add("Hà Lan");
            CB_Language.Items.Add("Anh");
        }

        private async void BTN_Submit_Click(object sender, EventArgs e)
        {
            string username = TB_Username.Text;
            string password = TB_Password.Text;
            string phone = TB_Phone.Text;
            string email = TB_Email.Text;
            string firstname = TB_Firstname.Text;
            string lastname = TB_Lastname.Text;
            string language = CB_Language.Text;
            int sex;
            if (RB_Male.Checked)
            {
                sex = 1;
            }
            else
            {
                sex = 0;
            }
            if (username == "")
            {
                MessageBox.Show("Không được để trống username!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Không được để trống password!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (phone == "")
            {
                MessageBox.Show("Không được để trống phone!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (firstname == "")
            {
                MessageBox.Show("Không được để trống firstname!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lastname == "")
            {
                MessageBox.Show("Không được để trống lastname!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (email == "")
            {
                MessageBox.Show("Không được để trống email!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (language == "")
            {
                MessageBox.Show("Không được để trống language!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!RB_F.Checked && !RB_Male.Checked)
            {
                MessageBox.Show("Không được để trống giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải lớn hơn hoặc bằng 8 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string birth = DTPicker.Value.ToString("yyyy-MM-dd");
            JObject json = new JObject();
            json["username"] = username;
            json["email"] = email;
            json["password"] = password;
            json["firstname"] = firstname;
            json["lastname"] = lastname;
            json["sex"] = sex;
            json["birthday"] = birth;
            json["language"] = language;
            json["phone"] = phone;

            try
            {
                string url = "https://nt106.uitiot.vn/api/v1/user/signup";
                string string_json = json.ToString();
                HttpContent content = new StringContent(string_json, Encoding.UTF8, "application/json");
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Đăng ký thất bại, đây là lỗi server trả về: " + responseContent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void LB_LOGIN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap dangNhap=new DangNhap();
            this.Hide();
            dangNhap.Show();
        }
    }
}
