namespace Bai6
{
    partial class Bai6_SendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai6_SendMail));
            mailfrom = new TextBox();
            name = new TextBox();
            subject = new TextBox();
            mailto = new TextBox();
            richTextBox1 = new RichTextBox();
            path = new TextBox();
            browse = new Button();
            send = new Button();
            checkBox = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // mailfrom
            // 
            mailfrom.BackColor = SystemColors.GradientInactiveCaption;
            mailfrom.Font = new Font("Microsoft Sans Serif", 10.8F);
            mailfrom.Location = new Point(91, 20);
            mailfrom.Name = "mailfrom";
            mailfrom.ReadOnly = true;
            mailfrom.Size = new Size(330, 28);
            mailfrom.TabIndex = 0;
            // 
            // name
            // 
            name.BackColor = SystemColors.GradientInactiveCaption;
            name.Font = new Font("Microsoft Sans Serif", 10.8F);
            name.Location = new Point(91, 58);
            name.Name = "name";
            name.Size = new Size(330, 28);
            name.TabIndex = 1;
            // 
            // subject
            // 
            subject.BackColor = SystemColors.GradientInactiveCaption;
            subject.Font = new Font("Microsoft Sans Serif", 10.8F);
            subject.Location = new Point(91, 129);
            subject.Name = "subject";
            subject.Size = new Size(330, 28);
            subject.TabIndex = 2;
            // 
            // mailto
            // 
            mailto.BackColor = SystemColors.GradientInactiveCaption;
            mailto.Font = new Font("Microsoft Sans Serif", 10.8F);
            mailto.Location = new Point(91, 92);
            mailto.Name = "mailto";
            mailto.Size = new Size(330, 28);
            mailto.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(91, 190);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(443, 300);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // path
            // 
            path.BackColor = SystemColors.GradientInactiveCaption;
            path.Font = new Font("Microsoft Sans Serif", 10.8F);
            path.Location = new Point(91, 510);
            path.Name = "path";
            path.Size = new Size(331, 28);
            path.TabIndex = 6;
            // 
            // browse
            // 
            browse.BackColor = Color.Transparent;
            browse.FlatAppearance.BorderColor = Color.SkyBlue;
            browse.FlatAppearance.BorderSize = 3;
            browse.FlatStyle = FlatStyle.Flat;
            browse.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            browse.Location = new Point(428, 505);
            browse.Name = "browse";
            browse.Size = new Size(106, 40);
            browse.TabIndex = 7;
            browse.Text = "Browse...";
            browse.UseVisualStyleBackColor = false;
            browse.Click += browse_Click;
            // 
            // send
            // 
            send.BackColor = Color.Transparent;
            send.FlatAppearance.BorderColor = Color.SkyBlue;
            send.FlatAppearance.BorderSize = 3;
            send.FlatStyle = FlatStyle.Flat;
            send.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic);
            send.Location = new Point(428, 556);
            send.Name = "send";
            send.Size = new Size(106, 52);
            send.TabIndex = 8;
            send.Text = "SEND";
            send.UseVisualStyleBackColor = false;
            send.Click += send_Click;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Font = new Font("Cambria", 10F);
            checkBox.Location = new Point(91, 160);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(76, 24);
            checkBox.TabIndex = 9;
            checkBox.Text = "HTML";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 11F);
            label3.Location = new Point(25, 20);
            label3.Name = "label3";
            label3.Size = new Size(60, 24);
            label3.TabIndex = 10;
            label3.Text = "From:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.Location = new Point(25, 58);
            label4.Name = "label4";
            label4.Size = new Size(66, 24);
            label4.TabIndex = 10;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 11F);
            label5.Location = new Point(7, 132);
            label5.Name = "label5";
            label5.Size = new Size(78, 24);
            label5.TabIndex = 10;
            label5.Text = "Subject:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 11F);
            label6.Location = new Point(47, 95);
            label6.Name = "label6";
            label6.Size = new Size(38, 24);
            label6.TabIndex = 10;
            label6.Text = "To:";
            // 
            // Bai6_SendMail
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(566, 620);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBox);
            Controls.Add(send);
            Controls.Add(browse);
            Controls.Add(path);
            Controls.Add(richTextBox1);
            Controls.Add(mailto);
            Controls.Add(subject);
            Controls.Add(name);
            Controls.Add(mailfrom);
            Name = "Bai6_SendMail";
            Text = "Send Mail";
            Load += Bai6_SendMail_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        public System.Windows.Forms.TextBox mailfrom;
        public System.Windows.Forms.TextBox name;
        public System.Windows.Forms.TextBox subject;
        public System.Windows.Forms.TextBox mailto;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.TextBox path;
        public System.Windows.Forms.Button browse;
        public System.Windows.Forms.Button send;
        public System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}