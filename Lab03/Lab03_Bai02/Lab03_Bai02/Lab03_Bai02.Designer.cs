namespace Lab03_Bai02
{
    partial class Lab03_Bai02
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
            lb_Out = new Label();
            btn_Listen = new Button();
            rtb_Out = new RichTextBox();
            SuspendLayout();
            // 
            // lb_Out
            // 
            lb_Out.AutoSize = true;
            lb_Out.Font = new Font("Cambria", 13F, FontStyle.Bold);
            lb_Out.Location = new Point(49, 76);
            lb_Out.Name = "lb_Out";
            lb_Out.Size = new Size(205, 26);
            lb_Out.TabIndex = 5;
            lb_Out.Text = "Received messages";
            lb_Out.Click += lb_Out_Click;
            // 
            // btn_Listen
            // 
            btn_Listen.BackColor = Color.SeaShell;
            btn_Listen.Font = new Font("Cambria", 13F, FontStyle.Bold);
            btn_Listen.Location = new Point(457, 64);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(124, 51);
            btn_Listen.TabIndex = 7;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = false;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // rtb_Out
            // 
            rtb_Out.Font = new Font("Cambria", 12F, FontStyle.Bold);
            rtb_Out.Location = new Point(49, 135);
            rtb_Out.Name = "rtb_Out";
            rtb_Out.ReadOnly = true;
            rtb_Out.Size = new Size(532, 362);
            rtb_Out.TabIndex = 8;
            rtb_Out.Text = "";
            // 
            // Lab03_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(633, 539);
            Controls.Add(rtb_Out);
            Controls.Add(btn_Listen);
            Controls.Add(lb_Out);
            Name = "Lab03_Bai02";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_Out;
        private Button btn_Listen;
        private RichTextBox rtb_Out;
    }
}
