using Newtonsoft.Json;
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
using System.Net.Http.Headers;
using System.Diagnostics;

namespace Bai7
{
    public partial class HomNayAnGi : Form
    {
        private string accessToken;
        private string usern;
        private JArray listmonan = new JArray();
        public HomNayAnGi(string token, string username)
        {
            InitializeComponent();
            this.accessToken = token;
            usern = username;
        }
        private void HomNayAnGi_Load(object sender, EventArgs e)
        {
            CB2.Items.Add("5");
            CB1.Items.Add("1");
            CB1.Items.Add("2");
            CB1.Items.Add("3");
            CB1.Items.Add("4");
            CB1.Items.Add("5");
            CB2.SelectedIndex = 0;
            CB1.SelectedIndex = 0;
        }

        private async Task LayVaHienThiMonAn()
        {
            FlowLayoutPanel currentFLP = (TC.SelectedIndex == 0) ? FLP1 : FLP2;

            PB.Style = ProgressBarStyle.Marquee;
            PB.MarqueeAnimationSpeed = 30;
            PB.Visible = true;

            if (currentFLP == FLP1)
            {
                try
                {
                    int hientai, size;
                    int.TryParse(CB1.Text, out hientai);

                    int.TryParse(CB2.Text, out size);

                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                    string url = "https://nt106.uitiot.vn/api/v1/monan/all";
                    var requestData = new
                    {
                        current = hientai,
                        pageSize = size
                    };
                    string jsonBody = JsonConvert.SerializeObject(requestData);
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        currentFLP.Controls.Clear();
                        string responseContent = await response.Content.ReadAsStringAsync();
                        dynamic ketQua = JsonConvert.DeserializeObject(responseContent);

                        foreach (var mon in ketQua.data)
                        {
                            Panel pnl = new Panel
                            {
                                Width = currentFLP.ClientSize.Width - 25,
                                Height = 130,
                                BorderStyle = BorderStyle.FixedSingle,
                                Margin = new Padding(5),
                                BackColor = Color.White
                            };
                            PictureBox pb = new PictureBox
                            {
                                Width = 110,
                                Height = 110,
                                Location = new Point(10, 10),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            if (mon.hinh_anh != null)
                            {
                                string urlAnh = (string)mon.hinh_anh;
                                urlAnh = (urlAnh ?? "").Trim();
                                if (!string.IsNullOrEmpty(urlAnh) &&
                                    Uri.TryCreate(urlAnh, UriKind.Absolute, out Uri uriResult) &&
                                    (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                                {
                                    _ = Task.Run(async () =>
                                    {
                                        try
                                        {
                                            using (var http = new HttpClient())
                                            {
                                                byte[] imgBytes = await http.GetByteArrayAsync(uriResult).ConfigureAwait(false);
                                                if (imgBytes != null && imgBytes.Length > 0)
                                                {
                                                    using (var ms = new System.IO.MemoryStream(imgBytes))
                                                    using (var tmp = Image.FromStream(ms))
                                                    {
                                                        Image safeImg = new Bitmap(tmp);

                                                        if (pb.IsHandleCreated)
                                                        {
                                                            pb.Invoke((Action)(() =>
                                                            {
                                                                var old = pb.Image;
                                                                pb.Image = safeImg;
                                                                if (old != null) old.Dispose();
                                                            }));
                                                        }
                                                        else
                                                        {
                                                            var old = pb.Image;
                                                            pb.Image = safeImg;
                                                            if (old != null) old.Dispose();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Debug.WriteLine("Load image failed: " + ex.ToString());
                                        }
                                    });
                                }
                            }

                            int labelX = 130;
                            int valueX = 210;
                            Label lbTen = new Label
                            {
                                Text = (string)mon.ten_mon_an,
                                Location = new Point(labelX, 10),
                                Size = new Size(pnl.Width - labelX - 10, 30),
                                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                                ForeColor = Color.FromArgb(192, 64, 0)
                            };
                            Label lbGiaTitle = new Label
                            {
                                Text = "Giá:",
                                Location = new Point(labelX, 45),
                                AutoSize = true,
                                Font = new Font("Segoe UI", 9, FontStyle.Bold)
                            };
                            Label lbGiaValue = new Label
                            {
                                Text = ((int)mon.gia).ToString() ?? "0",
                                Location = new Point(valueX, 45),
                                AutoSize = true,
                                Font = new Font("Segoe UI", 9, FontStyle.Regular)
                            };
                            Label lbDiaChiTitle = new Label
                            {
                                Text = "Địa chỉ:",
                                Location = new Point(labelX, 70),
                                AutoSize = true,
                                Font = new Font("Segoe UI", 9, FontStyle.Bold)
                            };
                            Label lbDiaChiValue = new Label
                            {
                                Text = (string)mon.dia_chi ?? "Chưa cập nhật",
                                Location = new Point(valueX, 70),
                                Size = new Size(pnl.Width - valueX - 5, 20),
                                AutoEllipsis = true,
                                Font = new Font("Segoe UI", 9, FontStyle.Regular)
                            };
                            Label lbDongGopTitle = new Label
                            {
                                Text = "Đóng góp:",
                                Location = new Point(labelX, 95),
                                AutoSize = true,
                                Font = new Font("Segoe UI", 9, FontStyle.Bold)
                            };
                            Label lbDongGopValue = new Label
                            {
                                Text = (string)mon.nguoi_dong_gop ?? "Ẩn danh",
                                Location = new Point(valueX, 95),
                                AutoSize = true,
                                ForeColor = Color.Green,
                                Font = new Font("Segoe UI", 9, FontStyle.Regular)
                            };
                            pnl.Controls.Add(pb);
                            pnl.Controls.Add(lbTen);
                            pnl.Controls.Add(lbGiaTitle);
                            pnl.Controls.Add(lbGiaValue);
                            pnl.Controls.Add(lbDiaChiTitle);
                            pnl.Controls.Add(lbDiaChiValue);
                            pnl.Controls.Add(lbDongGopTitle);
                            pnl.Controls.Add(lbDongGopValue);
                            currentFLP.Controls.Add(pnl);
                        }
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Lỗi tải món (Mã {response.StatusCode}): {error}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi code: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    int hientai, size;
                    int.TryParse(CB1.Text, out hientai);
                    int.TryParse(CB2.Text, out size);
                    currentFLP.Controls.Clear();
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                    string url = "https://nt106.uitiot.vn/api/v1/monan/my-dishes";
                    int tongtotal = 0;


                    var requestData = new
                    {
                        current = hientai,
                        pageSize = size
                    };
                    string jsonBody = JsonConvert.SerializeObject(requestData);
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {

                        string responseContent = await response.Content.ReadAsStringAsync();
                        dynamic ketQua = JsonConvert.DeserializeObject(responseContent);
                        tongtotal = (int)ketQua.pagination.total;
                        foreach (var mon in ketQua.data)
                        {


                            Panel pnl = new Panel
                            {
                                Width = currentFLP.ClientSize.Width - 25,
                                Height = 130,
                                BorderStyle = BorderStyle.FixedSingle,
                                Margin = new Padding(5),
                                BackColor = Color.White
                            };
                            PictureBox pb = new PictureBox
                            {
                                Width = 110,
                                Height = 110,
                                Location = new Point(10, 10),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                BorderStyle = BorderStyle.FixedSingle
                            };
                            if (mon.hinh_anh != null)
                            {
                                string urlAnh = (string)mon.hinh_anh;
                                urlAnh = (urlAnh ?? "").Trim();
                                if (!string.IsNullOrEmpty(urlAnh) &&
                                    Uri.TryCreate(urlAnh, UriKind.Absolute, out Uri uriResult) &&
                                    (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                                {
                                    _ = Task.Run(async () =>
                                    {
                                        try
                                        {
                                            using (var http = new HttpClient())
                                            {
                                                byte[] imgBytes = await http.GetByteArrayAsync(uriResult).ConfigureAwait(false);
                                                if (imgBytes != null && imgBytes.Length > 0)
                                                {
                                                    using (var ms = new System.IO.MemoryStream(imgBytes))
                                                    using (var tmp = Image.FromStream(ms))
                                                    {
                                                        Image safeImg = new Bitmap(tmp);

                                                        if (pb.IsHandleCreated)
                                                        {
                                                            pb.Invoke((Action)(() =>
                                                            {
                                                                var old = pb.Image;
                                                                pb.Image = safeImg;
                                                                if (old != null) old.Dispose();
                                                            }));
                                                        }
                                                        else
                                                        {
                                                            var old = pb.Image;
                                                            pb.Image = safeImg;
                                                            if (old != null) old.Dispose();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Debug.WriteLine("Load image failed: " + ex.ToString());
                                        }
                                    });
                                }
                            }
                            int labelX = 130;
                            int valueX = 210;
                            Label lbTen = new Label
                            {
                                Text = (string)mon.ten_mon_an,
                                Location = new Point(labelX, 10),
                                Size = new Size(pnl.Width - labelX - 10, 30),
                                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                                ForeColor = Color.FromArgb(192, 64, 0)
                            };
                            Label lbGiaTitle = new Label
                            {
                                Text = "Giá:",
                                Location = new Point(labelX, 45),
                                AutoSize = true,
                                Font = new Font("Segoe UI", 9, FontStyle.Bold)
                            };
                            Label lbGiaValue = new Label
                            {
                                Text = ((int)mon.gia).ToString() ?? "0",
                                Location = new Point(valueX, 45),
                                AutoSize = true,
                                Font = new Font("Segoe UI", 9, FontStyle.Regular)
                            };
                            Label lbDiaChiTitle = new Label
                            {
                                Text = "Địa chỉ:",
                                Location = new Point(labelX, 70),
                                AutoSize = true,
                                Font = new Font("Segoe UI", 9, FontStyle.Bold)
                            };
                            Label lbDiaChiValue = new Label
                            {
                                Text = (string)mon.dia_chi ?? "Chưa cập nhật",
                                Location = new Point(valueX, 70),
                                Size = new Size(pnl.Width - valueX - 5, 20),
                                AutoEllipsis = true,
                                Font = new Font("Segoe UI", 9, FontStyle.Regular)
                            };
                            Label lbDongGopTitle = new Label
                            {
                                Text = "Đóng góp:",
                                Location = new Point(labelX, 95),
                                AutoSize = true,
                                Font = new Font("Segoe UI", 9, FontStyle.Bold)
                            };
                            Label lbDongGopValue = new Label
                            {
                                Text = (string)mon.nguoi_dong_gop ?? "Ẩn danh",
                                Location = new Point(valueX, 95),
                                AutoSize = true,
                                ForeColor = Color.Green,
                                Font = new Font("Segoe UI", 9, FontStyle.Regular)
                            };
                            pnl.Controls.Add(pb);
                            pnl.Controls.Add(lbTen);
                            pnl.Controls.Add(lbGiaTitle);
                            pnl.Controls.Add(lbGiaValue);
                            pnl.Controls.Add(lbDiaChiTitle);
                            pnl.Controls.Add(lbDiaChiValue);
                            pnl.Controls.Add(lbDongGopTitle);
                            pnl.Controls.Add(lbDongGopValue);
                            currentFLP.Controls.Add(pnl);
                        }

                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Lỗi tải món (Mã {response.StatusCode}): {error}");

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi code: " + ex.Message);
                }

            }
            PB.Invoke((Action)(() =>
                {
                    PB.Style = ProgressBarStyle.Blocks;
                    PB.Visible = false;
                }));

        }


        private void CB1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int number = int.Parse(CB1.Text);
                int max = int.Parse(CB2.Text);
                if (number >= 1)
                {
                    LayVaHienThiMonAn();

                }
                else
                {
                    MessageBox.Show("Số trang nhập không hợp lệ, số trang phải từ 1 trở đi", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async Task laydanhsachmonan()
        {
            int hientai = int.Parse(CB1.Text);
            int size = int.Parse(CB2.Text);
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            string url = "https://nt106.uitiot.vn/api/v1/monan/all";


            while (true)
            {
                var requestData = new
                {
                    current = hientai,
                    pageSize = size
                };

                string jsonBody = JsonConvert.SerializeObject(requestData);

                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseContent = await response.Content.ReadAsStringAsync();
                dynamic ketQua = JsonConvert.DeserializeObject(responseContent);
                int totalItems = (int)ketQua.pagination.total;
                if (ketQua.data != null)
                {
                    listmonan.Merge(ketQua.data);

                }

                hientai++;
                if (hientai > totalItems) break;
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {

            if (listmonan == null || listmonan.Count == 0)
               await  laydanhsachmonan();
            Random random = new Random();
            int ngaunhien = random.Next(0, listmonan.Count);
            var monngaunhien = listmonan[ngaunhien];
            AnGiGio anGiGio = new AnGiGio(monngaunhien);

            anGiGio.Show();

        }

        private async void button3_Click(object sender, EventArgs e)
        {

            ThemMonAn them = new ThemMonAn(usern, accessToken);
            them.ShowDialog();
            LayVaHienThiMonAn();
        }

        private void TC_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayVaHienThiMonAn();

        }

        private void CB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayVaHienThiMonAn();

        }

        private void CB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayVaHienThiMonAn();

        }

        private void CB2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int number = int.Parse(CB1.Text);
                int max = int.Parse(CB2.Text);
                if (number >= 1)
                {
                    LayVaHienThiMonAn();

                }
                else
                {
                    MessageBox.Show("Số trang nhập không hợp lệ, số trang phải từ 1 trở đi", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}