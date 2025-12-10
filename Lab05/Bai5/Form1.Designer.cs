namespace Bai5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            btnDuyetMail = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            btnRandom = new Button();
            lblTenMon = new Label();
            pictureBox1 = new PictureBox();
            lblContributor = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(btnDuyetMail);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(133, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(776, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin - Duyệt đóng góp";
            // 
            // btnDuyetMail
            // 
            btnDuyetMail.BackColor = Color.LightSkyBlue;
            btnDuyetMail.FlatStyle = FlatStyle.Flat;
            btnDuyetMail.Location = new Point(635, 30);
            btnDuyetMail.Margin = new Padding(3, 4, 3, 4);
            btnDuyetMail.Name = "btnDuyetMail";
            btnDuyetMail.Size = new Size(126, 48);
            btnDuyetMail.TabIndex = 4;
            btnDuyetMail.Text = "DUYỆT MAIL";
            btnDuyetMail.UseVisualStyleBackColor = false;
            btnDuyetMail.Click += btnDuyetMail_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(403, 41);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(217, 27);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 44);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(63, 41);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 27);
            txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // btnRandom
            // 
            btnRandom.BackColor = Color.Coral;
            btnRandom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRandom.ForeColor = Color.White;
            btnRandom.Location = new Point(390, 139);
            btnRandom.Margin = new Padding(3, 4, 3, 4);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(262, 70);
            btnRandom.TabIndex = 5;
            btnRandom.Text = "HÔM NAY ĂN GÌ ?";
            btnRandom.UseVisualStyleBackColor = false;
            btnRandom.Click += btnRandom_Click;
            // 
            // lblTenMon
            // 
            lblTenMon.BackColor = Color.SeaShell;
            lblTenMon.Font = new Font("Cambria", 20F, FontStyle.Bold);
            lblTenMon.ForeColor = Color.DarkGreen;
            lblTenMon.Location = new Point(361, 222);
            lblTenMon.Name = "lblTenMon";
            lblTenMon.Size = new Size(329, 52);
            lblTenMon.TabIndex = 6;
            lblTenMon.Text = "Chưa chọn món";
            lblTenMon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(299, 278);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 364);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblContributor
            // 
            lblContributor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblContributor.ForeColor = Color.DimGray;
            lblContributor.Location = new Point(216, 662);
            lblContributor.Name = "lblContributor";
            lblContributor.Size = new Size(635, 29);
            lblContributor.TabIndex = 8;
            lblContributor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1004, 718);
            Controls.Add(lblContributor);
            Controls.Add(pictureBox1);
            Controls.Add(lblTenMon);
            Controls.Add(btnRandom);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Bài 5: Cộng đồng món ăn";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDuyetMail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContributor;
    }
}