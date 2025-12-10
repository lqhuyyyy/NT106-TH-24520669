namespace Bai6
{
    partial class Form1
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
            btnLogin = new Button();
            rtbLog = new RichTextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(74, 25);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 44);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Hiển thị thông tin user";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnGetInfo_Click;
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(30, 88);
            rtbLog.Margin = new Padding(3, 4, 3, 4);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(340, 361);
            rtbLog.TabIndex = 3;
            rtbLog.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 475);
            Controls.Add(rtbLog);
            Controls.Add(btnLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Lab 4 - HTTP Login";
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}