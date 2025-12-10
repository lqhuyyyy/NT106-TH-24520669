namespace Bai5
{
    partial class Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUrl = new Label();
            txtUrl = new TextBox();
            lblUser = new Label();
            txtUsername = new TextBox();
            lblPass = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            rtbResponse = new RichTextBox();
            lblResult = new Label();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Font = new Font("Cambria", 12F);
            lblUrl.ForeColor = Color.FromArgb(64, 64, 64);
            lblUrl.Location = new Point(25, 70);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(46, 23);
            lblUrl.TabIndex = 0;
            lblUrl.Text = "URL";
            // 
            // txtUrl
            // 
            txtUrl.BackColor = Color.WhiteSmoke;
            txtUrl.BorderStyle = BorderStyle.FixedSingle;
            txtUrl.Font = new Font("Cambria", 12F);
            txtUrl.Location = new Point(29, 96);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(480, 31);
            txtUrl.TabIndex = 1;
            txtUrl.Text = "https://nt106.uitiot.vn/auth/token";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Cambria", 12F);
            lblUser.ForeColor = Color.FromArgb(64, 64, 64);
            lblUser.Location = new Point(25, 140);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(98, 23);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Cambria", 12F);
            txtUsername.Location = new Point(29, 166);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 31);
            txtUsername.TabIndex = 2;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Cambria", 12F);
            lblPass.ForeColor = Color.FromArgb(64, 64, 64);
            lblPass.Location = new Point(25, 210);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(94, 23);
            lblPass.TabIndex = 4;
            lblPass.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Cambria", 12F);
            txtPassword.Location = new Point(29, 236);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(280, 31);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(147, 43, 24);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Cambria", 19F, FontStyle.Bold | FontStyle.Italic);
            btnLogin.ForeColor = Color.FromArgb(251, 216, 68);
            btnLogin.Location = new Point(335, 166);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(174, 101);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // rtbResponse
            // 
            rtbResponse.BackColor = Color.FromArgb(240, 242, 245);
            rtbResponse.BorderStyle = BorderStyle.None;
            rtbResponse.Font = new Font("Cambria", 12F);
            rtbResponse.Location = new Point(29, 315);
            rtbResponse.Name = "rtbResponse";
            rtbResponse.ReadOnly = true;
            rtbResponse.Size = new Size(480, 179);
            rtbResponse.TabIndex = 5;
            rtbResponse.Text = "";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Cambria", 12F);
            lblResult.ForeColor = Color.FromArgb(64, 64, 64);
            lblResult.Location = new Point(25, 289);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(156, 23);
            lblResult.TabIndex = 8;
            lblResult.Text = "Response Result:";
            lblResult.Click += lblResult_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(147, 43, 24);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(542, 50);
            panelHeader.TabIndex = 9;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Cambria", 15F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(251, 216, 68);
            labelTitle.Location = new Point(25, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(218, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "HTTP POST Client";
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(542, 506);
            Controls.Add(panelHeader);
            Controls.Add(lblResult);
            Controls.Add(rtbResponse);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPass);
            Controls.Add(txtUsername);
            Controls.Add(lblUser);
            Controls.Add(txtUrl);
            Controls.Add(lblUrl);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Bai5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 4 - Bài 5";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
    }
}