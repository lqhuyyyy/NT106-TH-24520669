using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class AnGiGio : Form
    {
        public AnGiGio(dynamic mon)
        {
                this.Size = new Size(600, 220);
                this.StartPosition = FormStartPosition.CenterParent; 
                this.Text = $"Ăn {mon.ten_mon_an} đi!!!!"; 
                this.BackColor = Color.White;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;

                PictureBox pb = new PictureBox
                {
                    Location = new Point(15, 15),
                    Size = new Size(180, 140), 
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
            int labelX = 210;
                int valueX = 320;
                Label lbTen = new Label
                {
                    Text = (string)mon.ten_mon_an,
                    Location = new Point(labelX, 15),
                    Size = new Size(260, 40),
                    Font = new Font("Segoe UI", 16, FontStyle.Bold), 
                    ForeColor = Color.FromArgb(192, 64, 0) 
                };
                Label CreateTitle(string text, int y) => new Label
                {
                    Text = text,
                    Location = new Point(labelX, y),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };
                Label CreateValue(string text, int y, Color c) => new Label
                {
                    Text = text,
                    Location = new Point(valueX, y),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    ForeColor = c
                };
                Label lbGiaTitle = CreateTitle("Giá:", 60);
                Label lbGiaVal = CreateValue(((int)mon.gia).ToString(), 60, Color.Black);
                Label lbDiaChiTitle = CreateTitle("Địa chỉ:", 90);
                Label lbDiaChiVal = CreateValue((string)mon.dia_chi, 90, Color.Black);
                lbDiaChiVal.Size = new Size(180, 40); 
                Label lbDongGopTitle = CreateTitle("Đóng góp:", 120);
                Label lbDongGopVal = CreateValue((string)mon.nguoi_dong_gop, 120, Color.Green);
                this.Controls.Add(pb);
                this.Controls.Add(lbTen);
                this.Controls.Add(lbGiaTitle);
                this.Controls.Add(lbGiaVal);
                this.Controls.Add(lbDiaChiTitle);
                this.Controls.Add(lbDiaChiVal);
                this.Controls.Add(lbDongGopTitle);
                this.Controls.Add(lbDongGopVal);
            
        }
    }
}
