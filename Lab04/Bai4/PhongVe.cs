using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks; 
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab04
{
    public partial class PhongVe : Form
    {
        public class Movie
        {
            public string Name { get; set; }
            public double BasePrice { get; set; }
            public List<int> Rooms { get; set; } = new List<int>();
            public int Sold { get; set; } = 0;
            public double Revenue { get; set; } = 0;
        }

        static Dictionary<string, Movie> databaseMovies = new Dictionary<string, Movie>();
        static HashSet<string> globalSoldSeats = new HashSet<string>();

        List<TabPage> allTabTemplates = new List<TabPage>();
        Movie currentMovie;

        public PhongVe(string movieName, double defaultPrice = 50000)
        {
            InitializeComponent();

            foreach (TabPage tab in tabControl1.TabPages)
                allTabTemplates.Add(tab);

            SetupMovieData(movieName, defaultPrice);

            foreach (TabPage tab in tabControl1.TabPages)
            {
                foreach (Control ctrl in tab.Controls)
                {
                    if (ctrl is CheckBox cb)
                        cb.CheckedChanged += Ghe_CheckedChanged;
                }
            }


            this.Text = $"Đặt vé phim: {movieName}";

        }

        private void SetupMovieData(string name, double price)
        {
            if (!databaseMovies.ContainsKey(name))
            {
                databaseMovies[name] = new Movie
                {
                    Name = name,
                    BasePrice = price,
                    Rooms = new List<int> { 1, 2, 3 }
                };
            }

            currentMovie = databaseMovies[name];

            RefreshSeatStatus();
        }

        private void RefreshSeatStatus()
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                int roomID = tabControl1.TabPages.IndexOf(tab) + 1;
                foreach (CheckBox cb in tab.Controls.OfType<CheckBox>())
                {
                    string key = $"{currentMovie.Name}-{roomID}-{cb.Text}";

                    if (globalSoldSeats.Contains(key))
                    {
                        cb.Checked = true;
                        cb.Enabled = false;
                        cb.BackColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        cb.Checked = false;
                        cb.Enabled = true;
                        cb.BackColor = System.Drawing.Color.White;
                    }
                }
            }
        }

        private void Ghe_CheckedChanged(object sender, EventArgs e)
        {
            int soPhongCoGhe = 0;
            int tongGhe = 0;

            foreach (TabPage tab in tabControl1.TabPages)
            {
                int gheTrongPhong = tab.Controls.OfType<CheckBox>().Count(cb => cb.Checked && cb.Enabled);
                if (gheTrongPhong > 0) soPhongCoGhe++;
                tongGhe += gheTrongPhong;
            }

            if (soPhongCoGhe > 1 && tongGhe > 2)
            {
                CheckBox cb = sender as CheckBox;
                if (cb != null && cb.Checked)
                {
                    cb.Checked = false;
                    MessageBox.Show("Chỉ được chọn tối đa 2 ghế khi chọn nhiều phòng!", "Luật đặt vé");
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                return;
            }

            List<string> gheMuaDotNay = new List<string>();
            double tongTien = 0;

            foreach (TabPage tab in tabControl1.TabPages)
            {
                int roomID = tabControl1.TabPages.IndexOf(tab) + 1;
                foreach (CheckBox cb in tab.Controls.OfType<CheckBox>())
                {
                    if (cb.Checked && cb.Enabled)
                    {
                        double giaGhe = currentMovie.BasePrice;

                        if (new[] { "A1", "A5", "C1", "C5" }.Contains(cb.Text)) giaGhe *= 0.25;
                        else if (new[] { "B2", "B3", "B4" }.Contains(cb.Text)) giaGhe *= 2.0;

                        tongTien += giaGhe;

                        string key = $"{currentMovie.Name}-{roomID}-{cb.Text}";
                        globalSoldSeats.Add(key);
                        gheMuaDotNay.Add($"P{roomID}-{cb.Text}");
                    }
                }
            }

            if (gheMuaDotNay.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào!");
                return;
            }

            currentMovie.Sold += gheMuaDotNay.Count;
            currentMovie.Revenue += tongTien;

            MessageBox.Show($"Thanh toán thành công!\nKhách: {tbName.Text}\nPhim: {currentMovie.Name}\nGhế: {string.Join(", ", gheMuaDotNay)}\nTổng tiền: {tongTien:#,##0} VNĐ");

            RefreshSeatStatus();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkB3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}