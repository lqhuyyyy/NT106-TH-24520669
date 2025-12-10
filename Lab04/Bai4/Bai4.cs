using HtmlAgilityPack; 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text.Json; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Bai4 : Form
    {
        
        public class MovieInfo
        {
            public string Title { get; set; }
            public string ImageUrl { get; set; }
            public string DetailUrl { get; set; }
            public string Genre { get; set; }
            public string Duration { get; set; }
        }

        public Bai4()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            btnLoad.Enabled = false;
            flpList.Controls.Clear();
            progressBar1.Value = 0;

            try
            {
                string url = "https://betacinemas.vn/phim.htm";

                List<MovieInfo> movies = await GetMoviesFromWebAsync(url);

                SaveMoviesToJson(movies, "movies.json");

                DisplayMovies(movies);

                MessageBox.Show($"Đã tải và lưu {movies.Count} phim vào movies.json!", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
            finally
            {
                btnLoad.Enabled = true;
                progressBar1.Value = 100;
            }
        }

        private async Task<List<MovieInfo>> GetMoviesFromWebAsync(string url)
        {
            var listMovies = new List<MovieInfo>();
            var web = new HtmlWeb();

            progressBar1.Value = 10;

            var doc = await Task.Run(() => web.Load(url));

            progressBar1.Value = 30;

            var movieNodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'col-lg-4') and contains(@class, 'col-md-4')]");

            if (movieNodes == null) return listMovies;

            int totalNodes = movieNodes.Count;
            int processed = 0;

            foreach (var node in movieNodes)
            {
                var movie = new MovieInfo();

                try
                {
                    var titleNode = node.SelectSingleNode(".//h3/a");
                    if (titleNode != null)
                    {
                        movie.Title = titleNode.InnerText.Trim();
                        string href = titleNode.GetAttributeValue("href", "");
                        movie.DetailUrl = href.StartsWith("http") ? href : "https://betacinemas.vn" + href;
                    }

                    var imgNode = node.SelectSingleNode(".//img");
                    if (imgNode != null)
                    {
                        movie.ImageUrl = imgNode.GetAttributeValue("src", "");
                    }

                    var infoNodes = node.SelectNodes(".//ul[contains(@class, 'info-film')]/li");
                    if (infoNodes != null && infoNodes.Count >= 1)
                    {
                        movie.Genre = infoNodes[0].InnerText.Trim();
                    }

                    listMovies.Add(movie);
                }
                catch { }

                processed++;
                int percentage = 30 + (processed * 70 / totalNodes);

                progressBar1.Value = percentage;

                await Task.Delay(100);
            }

            return listMovies;
        }

        private void SaveMoviesToJson(List<MovieInfo> movies, string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(movies, options);
            File.WriteAllText(filePath, jsonString);
        }

        private void DisplayMovies(List<MovieInfo> movies)
        {
            Font fontTitle = new Font("Cambria", 13, FontStyle.Bold);
            Font fontText = new Font("Cambria", 10, FontStyle.Regular);
            Font fontButton = new Font("Cambria", 10, FontStyle.Bold);

            foreach (var movie in movies)
            {
                Panel pnl = new Panel();
                pnl.Size = new Size(flpList.Width - 25, 130); 
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.Margin = new Padding(5);
                pnl.BackColor = Color.White;

                PictureBox pb = new PictureBox();
                pb.Size = new Size(85, 110);
                pb.Location = new Point(10, 10);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                try { pb.Load(movie.ImageUrl); } catch { }

                Label lblTitle = new Label();
                lblTitle.Text = movie.Title;
                lblTitle.Font = fontTitle; 
                lblTitle.ForeColor = Color.DarkBlue;
                lblTitle.Location = new Point(105, 10);
                lblTitle.AutoSize = false; 
                lblTitle.Size = new Size(220, 45); 

                Label lblGenre = new Label();
                lblGenre.Text = "Thể loại: " + movie.Genre;
                lblGenre.Font = fontText;
                lblGenre.ForeColor = Color.DimGray;
                lblGenre.Location = new Point(105, 55); 
                lblGenre.AutoSize = true;

                Button btnDetail = new Button();
                btnDetail.Text = "Xem chi tiết";
                btnDetail.Font = fontButton;
                btnDetail.Size = new Size(120, 30);
                btnDetail.Location = new Point(105, 85);
                btnDetail.BackColor = Color.WhiteSmoke;
                btnDetail.Cursor = Cursors.Hand;
                btnDetail.Click += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(movie.DetailUrl)) webBrowser1.Navigate(movie.DetailUrl);
                };

                Button btnBook = new Button();
                btnBook.Text = "Đặt vé";
                btnBook.Font = fontButton;
                btnBook.Size = new Size(80, 30);
                btnBook.Location = new Point(235, 85);
                btnBook.BackColor = Color.OrangeRed;
                btnBook.ForeColor = Color.White;
                btnBook.FlatStyle = FlatStyle.Flat;
                btnBook.FlatAppearance.BorderSize = 0;
                btnBook.Cursor = Cursors.Hand;
                btnBook.Click += (s, e) =>
                {
                    PhongVe formDatVe = new PhongVe(movie.Title, 50000);

                    formDatVe.ShowDialog();
                };

                pnl.Controls.Add(pb);
                pnl.Controls.Add(lblTitle);
                pnl.Controls.Add(lblGenre);
                pnl.Controls.Add(btnDetail);
                pnl.Controls.Add(btnBook);

                flpList.Controls.Add(pnl);
            }
        }
    }
}