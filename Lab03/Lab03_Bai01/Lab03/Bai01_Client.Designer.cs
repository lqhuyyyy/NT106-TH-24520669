namespace Lab03_Bai01
{
    partial class Bai01_Client
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
            lb_Port = new Label();
            label1 = new Label();
            label2 = new Label();
            rtb_Out = new RichTextBox();
            tb_Port = new TextBox();
            tb_IP = new TextBox();
            btn_Send = new Button();
            SuspendLayout();
            // 
            // lb_Port
            // 
            lb_Port.AutoSize = true;
            lb_Port.Font = new Font("Cambria", 12F, FontStyle.Bold);
            lb_Port.Location = new Point(109, 114);
            lb_Port.Name = "lb_Port";
            lb_Port.Size = new Size(149, 23);
            lb_Port.TabIndex = 4;
            lb_Port.Text = "IP remote host:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label1.Location = new Point(427, 114);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 4;
            label1.Text = "Port:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label2.Location = new Point(109, 201);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 4;
            label2.Text = "Message:";
            // 
            // rtb_Out
            // 
            rtb_Out.Font = new Font("Cambria", 11F, FontStyle.Bold);
            rtb_Out.Location = new Point(109, 244);
            rtb_Out.Name = "rtb_Out";
            rtb_Out.Size = new Size(535, 85);
            rtb_Out.TabIndex = 5;
            rtb_Out.Text = "";
            // 
            // tb_Port
            // 
            tb_Port.Font = new Font("Cambria", 11F);
            tb_Port.Location = new Point(427, 149);
            tb_Port.Name = "tb_Port";
            tb_Port.Size = new Size(104, 29);
            tb_Port.TabIndex = 6;
            // 
            // tb_IP
            // 
            tb_IP.Font = new Font("Cambria", 11F);
            tb_IP.Location = new Point(109, 149);
            tb_IP.Name = "tb_IP";
            tb_IP.Size = new Size(248, 29);
            tb_IP.TabIndex = 6;
            // 
            // btn_Send
            // 
            btn_Send.BackColor = Color.SeaShell;
            btn_Send.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btn_Send.Location = new Point(544, 57);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(100, 35);
            btn_Send.TabIndex = 7;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Click += btn_Send_Click;
            // 
            // Bai01_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(747, 413);
            Controls.Add(btn_Send);
            Controls.Add(tb_IP);
            Controls.Add(tb_Port);
            Controls.Add(rtb_Out);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb_Port);
            Name = "Bai01_Client";
            Text = "Bai01_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Port;
        private Label label1;
        private Label label2;
        private RichTextBox rtb_Out;
        private TextBox tb_Port;
        private TextBox textBox1;
        private TextBox tb_IP;
        private Button btn_Send;
    }
}