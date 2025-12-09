namespace Bai6
{
    partial class Bai6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai6));
            boxLogin = new GroupBox();
            logout = new Button();
            sendMail = new Button();
            refresh = new Button();
            login = new Button();
            label2 = new Label();
            label1 = new Label();
            password = new TextBox();
            username = new TextBox();
            groupBox2 = new GroupBox();
            smptPort = new TextBox();
            imapPort = new TextBox();
            smtpBox = new TextBox();
            imapBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView = new DataGridView();
            number = new DataGridViewTextBoxColumn();
            from = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            datetime = new DataGridViewTextBoxColumn();
            boxLogin.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // boxLogin
            // 
            boxLogin.BackColor = Color.Transparent;
            boxLogin.Controls.Add(logout);
            boxLogin.Controls.Add(sendMail);
            boxLogin.Controls.Add(refresh);
            boxLogin.Controls.Add(login);
            boxLogin.Controls.Add(label2);
            boxLogin.Controls.Add(label1);
            boxLogin.Controls.Add(password);
            boxLogin.Controls.Add(username);
            boxLogin.FlatStyle = FlatStyle.Flat;
            boxLogin.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boxLogin.ForeColor = Color.MidnightBlue;
            boxLogin.Location = new Point(23, 18);
            boxLogin.Margin = new Padding(4, 5, 4, 5);
            boxLogin.Name = "boxLogin";
            boxLogin.Padding = new Padding(4, 5, 4, 5);
            boxLogin.Size = new Size(612, 175);
            boxLogin.TabIndex = 0;
            boxLogin.TabStop = false;
            boxLogin.Text = "Login";
            // 
            // logout
            // 
            logout.Font = new Font("Cambria", 10F);
            logout.Location = new Point(485, 123);
            logout.Margin = new Padding(4, 5, 4, 5);
            logout.Name = "logout";
            logout.Size = new Size(113, 42);
            logout.TabIndex = 7;
            logout.Text = "LOGOUT";
            logout.UseVisualStyleBackColor = true;
            logout.Visible = false;
            logout.Click += logout_Click;
            // 
            // sendMail
            // 
            sendMail.Font = new Font("Cambria", 10F);
            sendMail.Location = new Point(485, 71);
            sendMail.Margin = new Padding(4, 5, 4, 5);
            sendMail.Name = "sendMail";
            sendMail.Size = new Size(113, 42);
            sendMail.TabIndex = 6;
            sendMail.Text = "SEND";
            sendMail.UseVisualStyleBackColor = true;
            sendMail.Visible = false;
            sendMail.Click += sendMail_Click;
            // 
            // refresh
            // 
            refresh.Font = new Font("Cambria", 10F);
            refresh.Location = new Point(485, 23);
            refresh.Margin = new Padding(4, 5, 4, 5);
            refresh.Name = "refresh";
            refresh.Size = new Size(113, 42);
            refresh.TabIndex = 5;
            refresh.Text = "REFRESH";
            refresh.UseVisualStyleBackColor = true;
            refresh.Visible = false;
            refresh.Click += refresh_Click;
            // 
            // login
            // 
            login.Font = new Font("Cambria", 10F);
            login.Location = new Point(485, 71);
            login.Margin = new Padding(4, 5, 4, 5);
            login.Name = "login";
            login.Size = new Size(113, 42);
            login.TabIndex = 4;
            login.Text = "LOGIN";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(8, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.Location = new Point(8, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "Email:";
            // 
            // password
            // 
            password.BackColor = SystemColors.GradientInactiveCaption;
            password.Font = new Font("Microsoft Sans Serif", 10.2F);
            password.Location = new Point(109, 97);
            password.Margin = new Padding(4, 5, 4, 5);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(355, 27);
            password.TabIndex = 1;
            // 
            // username
            // 
            username.BackColor = SystemColors.GradientInactiveCaption;
            username.Font = new Font("Microsoft Sans Serif", 10.2F);
            username.Location = new Point(109, 42);
            username.Margin = new Padding(4, 5, 4, 5);
            username.Name = "username";
            username.Size = new Size(355, 27);
            username.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(smptPort);
            groupBox2.Controls.Add(imapPort);
            groupBox2.Controls.Add(smtpBox);
            groupBox2.Controls.Add(imapBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.MidnightBlue;
            groupBox2.Location = new Point(643, 18);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(452, 175);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Setting";
            // 
            // smptPort
            // 
            smptPort.BackColor = SystemColors.GradientInactiveCaption;
            smptPort.Font = new Font("Microsoft Sans Serif", 10.2F);
            smptPort.Location = new Point(379, 97);
            smptPort.Margin = new Padding(4, 5, 4, 5);
            smptPort.Name = "smptPort";
            smptPort.ReadOnly = true;
            smptPort.Size = new Size(59, 27);
            smptPort.TabIndex = 6;
            smptPort.Text = "465";
            // 
            // imapPort
            // 
            imapPort.BackColor = SystemColors.GradientInactiveCaption;
            imapPort.Font = new Font("Microsoft Sans Serif", 10.2F);
            imapPort.Location = new Point(379, 42);
            imapPort.Margin = new Padding(4, 5, 4, 5);
            imapPort.Name = "imapPort";
            imapPort.ReadOnly = true;
            imapPort.Size = new Size(59, 27);
            imapPort.TabIndex = 5;
            imapPort.Text = "993";
            // 
            // smtpBox
            // 
            smtpBox.BackColor = SystemColors.GradientInactiveCaption;
            smtpBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            smtpBox.Location = new Point(75, 97);
            smtpBox.Margin = new Padding(4, 5, 4, 5);
            smtpBox.Name = "smtpBox";
            smtpBox.ReadOnly = true;
            smtpBox.Size = new Size(236, 27);
            smtpBox.TabIndex = 4;
            smtpBox.Text = "smtp.gmail.com";
            // 
            // imapBox
            // 
            imapBox.BackColor = SystemColors.GradientInactiveCaption;
            imapBox.Font = new Font("Microsoft Sans Serif", 10.2F);
            imapBox.Location = new Point(75, 42);
            imapBox.Margin = new Padding(4, 5, 4, 5);
            imapBox.Name = "imapBox";
            imapBox.ReadOnly = true;
            imapBox.Size = new Size(236, 27);
            imapBox.TabIndex = 2;
            imapBox.Text = "imap.gmail.com";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(323, 45);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 3;
            label6.Text = "Port";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(323, 100);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 2;
            label5.Text = "Port";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(8, 103);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 1;
            label4.Text = "SMTP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(8, 45);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 0;
            label3.Text = "IMAP";
            label3.Click += label3_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { number, from, subject, datetime });
            dataGridView.Location = new Point(23, 203);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1072, 611);
            dataGridView.TabIndex = 2;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // number
            // 
            number.HeaderText = "No.";
            number.MinimumWidth = 6;
            number.Name = "number";
            number.ReadOnly = true;
            number.Width = 50;
            // 
            // from
            // 
            from.HeaderText = "From";
            from.MinimumWidth = 6;
            from.Name = "from";
            from.ReadOnly = true;
            from.Width = 300;
            // 
            // subject
            // 
            subject.HeaderText = "Subject";
            subject.MinimumWidth = 6;
            subject.Name = "subject";
            subject.ReadOnly = true;
            subject.Width = 450;
            // 
            // datetime
            // 
            datetime.HeaderText = "Date & Time";
            datetime.MinimumWidth = 6;
            datetime.Name = "datetime";
            datetime.ReadOnly = true;
            datetime.Width = 219;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1121, 832);
            Controls.Add(dataGridView);
            Controls.Add(groupBox2);
            Controls.Add(boxLogin);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Bai6";
            Text = "Bai6: Email Client";
            boxLogin.ResumeLayout(false);
            boxLogin.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox boxLogin;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox smptPort;
        private System.Windows.Forms.TextBox imapPort;
        private System.Windows.Forms.TextBox smtpBox;
        private System.Windows.Forms.TextBox imapBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendMail;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime;
    }
}