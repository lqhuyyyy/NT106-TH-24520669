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
using System.Text.Json.Nodes;
using System.Net.Http.Json;
using System.Net.Http.Headers;

namespace Bai7
{
    public partial class ThemMonAn : Form
    {
        private string tennguoinhap;
        private string token;
        public ThemMonAn(string username, string accesstoken)
        {
            
            InitializeComponent();
            tennguoinhap=username;
            token = accesstoken;
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TB_DiaChi.Clear();
            TB_Gia.Clear();
            TB_HinhAnh.Clear();
            RTB_Mota.Clear();
            TB_Ten.Clear();
        }

        private async void  BTN_Them_Click(object sender, EventArgs e)
        {
            string ten=TB_Ten.Text;
            string diachi=TB_DiaChi.Text;
            string hinhanh = TB_HinhAnh.Text;
            string mota = RTB_Mota.Text;
            string gia=TB_Gia.Text;
            if(ten=="")
            {
                MessageBox.Show("Tên không được trống", "Lỗi nhập tên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (diachi == "")
            {
                MessageBox.Show("Địa chỉ không được trống", "Lỗi nhập địa chỉ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (hinhanh == "")
            {
                MessageBox.Show("Hình ảnh không được trống", "Lỗi nhập hình ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gia == "")
            {
                MessageBox.Show("Giá không được trống", "Lỗi nhập Giá ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mota == "")
            {
                MessageBox.Show("Mô tả không được trống", "Lỗi nhập mô tả ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JObject json = new JObject();
            json["ten_mon_an"] = ten;
            json["gia"] = gia;
            json["mo_ta"] = mota;
            json["hinh_anh"] = hinhanh;
            json["dia_chi"] = diachi;
            json["nguoi_dong_gop"] = tennguoinhap;
            string url = "https://nt106.uitiot.vn/api/v1/monan/add";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
           new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            string string_json = json.ToString();
            HttpContent content = new StringContent(string_json, Encoding.UTF8, "application/json");
            
            
            HttpResponseMessage response = await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Thêm món thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Thêm món thất bại, đây là lỗi server trả về: " + responseContent);
            }


        }
    }
}
