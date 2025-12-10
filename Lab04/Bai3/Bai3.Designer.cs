namespace Bai3
{
    partial class Bai3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtURL_B3 = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDownloadHTML = new System.Windows.Forms.Button();
            this.btnDownloadResources = new System.Windows.Forms.Button();
            this.webView = new System.Windows.Forms.WebBrowser();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();

            this.pnlTop.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // Label Title
            this.lblTitle.Text = "Web Browser & Resource Downloader";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Height = 50;

            // Panel Top (URL bar)
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 50;
            this.pnlTop.Padding = new System.Windows.Forms.Padding(10);

            // URL TextBox
            this.txtURL_B3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtURL_B3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtURL_B3.PlaceholderText = "Nhập URL để tải trang...";

            // Load Button
            this.btnLoad.Text = "Load";
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Width = 90;
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            this.pnlTop.Controls.Add(this.txtURL_B3);
            this.pnlTop.Controls.Add(this.btnLoad);

            // Panel Buttons (Download)
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Height = 60;
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(10);
            this.pnlButtons.BackColor = System.Drawing.Color.WhiteSmoke;

            // Download HTML button
            this.btnDownloadHTML.Text = "Tải HTML";
            this.btnDownloadHTML.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDownloadHTML.Width = 130;
            this.btnDownloadHTML.Height = 40;
            this.btnDownloadHTML.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDownloadHTML.ForeColor = System.Drawing.Color.White;
            this.btnDownloadHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadHTML.Click += new System.EventHandler(this.btnDownloadHTML_Click);

            // Download Resources button
            this.btnDownloadResources.Text = "Tải hình ảnh";
            this.btnDownloadResources.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDownloadResources.Width = 130;
            this.btnDownloadResources.Height = 40;
            this.btnDownloadResources.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDownloadResources.ForeColor = System.Drawing.Color.White;
            this.btnDownloadResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadResources.Click += new System.EventHandler(this.btnDownloadResources_Click);

            // Add buttons
            this.pnlButtons.Controls.Add(this.btnDownloadResources);
            this.pnlButtons.Controls.Add(this.btnDownloadHTML);

            // Position buttons (right aligned)
            this.btnDownloadResources.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDownloadHTML.Dock = System.Windows.Forms.DockStyle.Left;

            // WebView (main browser)
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;

            // Form3 settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form3";
            this.Text = "Lab 4 - Bài 3 | Trình duyệt + Tải tài nguyên";

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtURL_B3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDownloadHTML;
        private System.Windows.Forms.Button btnDownloadResources;
        private System.Windows.Forms.WebBrowser webView;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlButtons;
    }
}
