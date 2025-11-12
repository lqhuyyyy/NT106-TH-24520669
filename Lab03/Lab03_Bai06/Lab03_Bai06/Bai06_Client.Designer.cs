namespace Lab03_Bai06
{
    partial class Bai06_Client
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
            title = new Label();
            label_message = new Label();
            label_name = new Label();
            button_send = new Button();
            textBox_message = new TextBox();
            textBox_name = new TextBox();
            listBox_chatboxC = new ListBox();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.Location = new Point(411, 43);
            title.Margin = new Padding(4, 0, 4, 0);
            title.Name = "title";
            title.Size = new Size(195, 48);
            title.TabIndex = 13;
            title.Text = "Chat Room";
            // 
            // label_message
            // 
            label_message.AutoSize = true;
            label_message.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label_message.Location = new Point(56, 577);
            label_message.Margin = new Padding(4, 0, 4, 0);
            label_message.Name = "label_message";
            label_message.Size = new Size(89, 23);
            label_message.TabIndex = 12;
            label_message.Text = "Message:";
            label_message.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label_name.Location = new Point(56, 498);
            label_name.Margin = new Padding(4, 0, 4, 0);
            label_name.Name = "label_name";
            label_name.Size = new Size(106, 23);
            label_name.TabIndex = 11;
            label_name.Text = "Your name:";
            label_name.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button_send
            // 
            button_send.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button_send.Location = new Point(845, 594);
            button_send.Margin = new Padding(4, 5, 4, 5);
            button_send.Name = "button_send";
            button_send.Size = new Size(136, 57);
            button_send.TabIndex = 10;
            button_send.Text = "SEND";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click;
            // 
            // textBox_message
            // 
            textBox_message.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_message.Location = new Point(61, 611);
            textBox_message.Margin = new Padding(4, 5, 4, 5);
            textBox_message.Name = "textBox_message";
            textBox_message.Size = new Size(753, 31);
            textBox_message.TabIndex = 9;
            textBox_message.KeyDown += textBox_message_KeyDown;
            // 
            // textBox_name
            // 
            textBox_name.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox_name.Location = new Point(61, 532);
            textBox_name.Margin = new Padding(4, 5, 4, 5);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(259, 31);
            textBox_name.TabIndex = 8;
            // 
            // listBox_chatboxC
            // 
            listBox_chatboxC.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            listBox_chatboxC.FormattingEnabled = true;
            listBox_chatboxC.ItemHeight = 23;
            listBox_chatboxC.Location = new Point(61, 108);
            listBox_chatboxC.Margin = new Padding(4, 5, 4, 5);
            listBox_chatboxC.Name = "listBox_chatboxC";
            listBox_chatboxC.ScrollAlwaysVisible = true;
            listBox_chatboxC.Size = new Size(949, 372);
            listBox_chatboxC.TabIndex = 7;
            // 
            // Bai06_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1067, 692);
            Controls.Add(title);
            Controls.Add(label_message);
            Controls.Add(label_name);
            Controls.Add(button_send);
            Controls.Add(textBox_message);
            Controls.Add(textBox_name);
            Controls.Add(listBox_chatboxC);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Bai06_Client";
            Text = "Bai06_Client";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ListBox listBox_chatboxC;
    }
}