namespace Lab03_Bai06
{
    partial class Bai06_Sever
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
            listBox_listChat = new ListBox();
            button_Listen = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.Location = new Point(47, 52);
            title.Margin = new Padding(4, 0, 4, 0);
            title.Name = "title";
            title.Size = new Size(300, 45);
            title.TabIndex = 5;
            title.Text = "Server - ChatRoom";
            // 
            // listBox_listChat
            // 
            listBox_listChat.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            listBox_listChat.FormattingEnabled = true;
            listBox_listChat.ItemHeight = 23;
            listBox_listChat.Location = new Point(55, 138);
            listBox_listChat.Margin = new Padding(4, 5, 4, 5);
            listBox_listChat.Name = "listBox_listChat";
            listBox_listChat.ScrollAlwaysVisible = true;
            listBox_listChat.Size = new Size(948, 487);
            listBox_listChat.TabIndex = 4;
            // 
            // button_Listen
            // 
            button_Listen.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button_Listen.Location = new Point(837, 52);
            button_Listen.Margin = new Padding(4, 5, 4, 5);
            button_Listen.Name = "button_Listen";
            button_Listen.Size = new Size(151, 55);
            button_Listen.TabIndex = 3;
            button_Listen.Text = "LISTEN";
            button_Listen.UseVisualStyleBackColor = true;
            button_Listen.Click += button_Listen_Click;
            // 
            // Bai06_Sever
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1061, 692);
            Controls.Add(title);
            Controls.Add(listBox_listChat);
            Controls.Add(button_Listen);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Bai06_Sever";
            Text = "Bai06_Sever";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListBox listBox_listChat;
        private System.Windows.Forms.Button button_Listen;
    }
}