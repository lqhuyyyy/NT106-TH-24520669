namespace Bai4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Panel pnlSoDoGhe;
        private System.Windows.Forms.TextBox txtGhDaChon;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtSenderEmail;
        private System.Windows.Forms.TextBox txtSenderPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.pnlSoDoGhe = new System.Windows.Forms.Panel();
            this.txtGhDaChon = new System.Windows.Forms.TextBox();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtSenderEmail = new System.Windows.Forms.TextBox();
            this.txtSenderPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPhim
            this.cboPhim.Location = new System.Drawing.Point(20, 20);
            this.cboPhim.Size = new System.Drawing.Size(200, 24);
            // 
            // pnlSoDoGhe
            this.pnlSoDoGhe.Location = new System.Drawing.Point(20, 60);
            this.pnlSoDoGhe.Size = new System.Drawing.Size(350, 250);
            // 
            // txtGhDaChon
            this.txtGhDaChon.Location = new System.Drawing.Point(20, 320);
            this.txtGhDaChon.Size = new System.Drawing.Size(350, 22);
            // 
            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(400, 20);
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoTen.PlaceholderText = "Họ tên";
            // 
            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(400, 60);
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.PlaceholderText = "Email người nhận";
            // 
            // txtSenderEmail
            this.txtSenderEmail.Location = new System.Drawing.Point(400, 100);
            this.txtSenderEmail.Size = new System.Drawing.Size(200, 22);
            this.txtSenderEmail.PlaceholderText = "Email gửi";
            // 
            // txtSenderPassword
            this.txtSenderPassword.Location = new System.Drawing.Point(400, 140);
            this.txtSenderPassword.Size = new System.Drawing.Size(200, 22);
            this.txtSenderPassword.UseSystemPasswordChar = true;
            this.txtSenderPassword.PlaceholderText = "App Password Gmail";
            // 
            // pbPoster
            this.pbPoster.Location = new System.Drawing.Point(400, 180);
            this.pbPoster.Size = new System.Drawing.Size(200, 250);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // btnDatVe
            this.btnDatVe.Location = new System.Drawing.Point(400, 440);
            this.btnDatVe.Size = new System.Drawing.Size(200, 30);
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // lblTrangThai
            this.lblTrangThai.Location = new System.Drawing.Point(20, 360);
            this.lblTrangThai.Size = new System.Drawing.Size(580, 22);
            this.lblTrangThai.Text = "";
            // 
            // Form1
            this.ClientSize = new System.Drawing.Size(640, 500);
            this.Controls.Add(this.cboPhim);
            this.Controls.Add(this.pnlSoDoGhe);
            this.Controls.Add(this.txtGhDaChon);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenderEmail);
            this.Controls.Add(this.txtSenderPassword);
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.lblTrangThai);
            this.Text = "Đặt vé Rạp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
