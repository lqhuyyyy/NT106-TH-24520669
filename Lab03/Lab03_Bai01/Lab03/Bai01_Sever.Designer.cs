namespace Lab03_Bai01
{
    partial class Bai01_Sever
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
            tb_Port = new TextBox();
            btn_Listen = new Button();
            lb_Port = new Label();
            lb_Out = new Label();
            SuspendLayout();
            // 
            // rtb_Out
            // 
            rtb_Out.Font = new Font("Cambria", 11F, FontStyle.Bold);
            rtb_Out.Location = new Point(114, 109);
            rtb_Out.Name = "rtb_Out";
            rtb_Out.ReadOnly = true;
            rtb_Out.Size = new Size(532, 281);
            rtb_Out.TabIndex = 0;
            rtb_Out.Text = "";
            // 
            // tb_Port
            // 
            tb_Port.Font = new Font("Cambria", 11F);
            tb_Port.Location = new Point(174, 35);
            tb_Port.Name = "tb_Port";
            tb_Port.Size = new Size(104, 29);
            tb_Port.TabIndex = 1;
            // 
            // btn_Listen
            // 
            btn_Listen.BackColor = Color.SeaShell;
            btn_Listen.Font = new Font("Cambria", 11F, FontStyle.Bold);
            btn_Listen.Location = new Point(546, 37);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(100, 35);
            btn_Listen.TabIndex = 2;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = false;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // lb_Port
            // 
            lb_Port.AutoSize = true;
            lb_Port.Font = new Font("Cambria", 11F, FontStyle.Bold);
            lb_Port.Location = new Point(114, 38);
            lb_Port.Name = "lb_Port";
            lb_Port.Size = new Size(54, 22);
            lb_Port.TabIndex = 3;
            lb_Port.Text = "Port:";
            // 
            // lb_Out
            // 
            lb_Out.AutoSize = true;
            lb_Out.Font = new Font("Cambria", 11F, FontStyle.Bold);
            lb_Out.Location = new Point(114, 77);
            lb_Out.Name = "lb_Out";
            lb_Out.Size = new Size(175, 22);
            lb_Out.TabIndex = 3;
            lb_Out.Text = "Received messages";
            // 
            // Bai01_Sever
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(747, 413);
            Controls.Add(lb_Out);
            Controls.Add(lb_Port);
            Controls.Add(btn_Listen);
            Controls.Add(tb_Port);
            Controls.Add(rtb_Out);
            Name = "Bai01_Sever";
            Text = "Bai01_Sever";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_Out;
        private TextBox tb_Port;
        private Button btn_Listen;
        private Label lb_Port;
        private Label lb_Out;
    }
}