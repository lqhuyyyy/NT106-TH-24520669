namespace Lab03_Bai03
{
    partial class Bai03_Client
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
            rtb_Out = new RichTextBox();
            btn_Connect = new Button();
            btn_Send = new Button();
            btn_Disconnect = new Button();
            SuspendLayout();
            // 
            // rtb_Out
            // 
            rtb_Out.Font = new Font("Cambria", 11F, FontStyle.Bold);
            rtb_Out.Location = new Point(12, 81);
            rtb_Out.Name = "rtb_Out";
            rtb_Out.Size = new Size(535, 305);
            rtb_Out.TabIndex = 5;
            rtb_Out.Text = "";
            // 
            // btn_Connect
            // 
            btn_Connect.BackColor = Color.SeaShell;
            btn_Connect.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btn_Connect.Location = new Point(580, 81);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(139, 64);
            btn_Connect.TabIndex = 7;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = false;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_Send
            // 
            btn_Send.BackColor = Color.SeaShell;
            btn_Send.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btn_Send.Location = new Point(580, 201);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(139, 64);
            btn_Send.TabIndex = 7;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Click += btn_Send_Click;
            // 
            // btn_Disconnect
            // 
            btn_Disconnect.BackColor = Color.SeaShell;
            btn_Disconnect.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btn_Disconnect.Location = new Point(580, 322);
            btn_Disconnect.Name = "btn_Disconnect";
            btn_Disconnect.Size = new Size(139, 64);
            btn_Disconnect.TabIndex = 7;
            btn_Disconnect.Text = "Disconnect";
            btn_Disconnect.UseVisualStyleBackColor = false;
            btn_Disconnect.Click += btn_Disconnect_Click;
            // 
            // Bai03_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(747, 413);
            Controls.Add(btn_Disconnect);
            Controls.Add(btn_Send);
            Controls.Add(btn_Connect);
            Controls.Add(rtb_Out);
            Name = "Bai03_Client";
            Text = "Bai03_Client";
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox rtb_Out;
        private TextBox textBox1;
        private Button btn_Connect;
        private Button btn_Send;
        private Button btn_Disconnect;
    }
}