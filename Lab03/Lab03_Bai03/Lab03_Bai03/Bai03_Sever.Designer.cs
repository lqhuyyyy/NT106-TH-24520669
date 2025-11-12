namespace Lab03_Bai03
{
    partial class Bai03_Sever
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
            btn_Listen = new Button();
            SuspendLayout();
            // 
            // rtb_Out
            // 
            rtb_Out.Font = new Font("Cambria", 11F, FontStyle.Bold);
            rtb_Out.Location = new Point(114, 75);
            rtb_Out.Name = "rtb_Out";
            rtb_Out.ReadOnly = true;
            rtb_Out.Size = new Size(532, 326);
            rtb_Out.TabIndex = 0;
            rtb_Out.Text = "";
            // 
            // btn_Listen
            // 
            btn_Listen.BackColor = Color.SeaShell;
            btn_Listen.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btn_Listen.Location = new Point(530, 27);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(116, 42);
            btn_Listen.TabIndex = 2;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = false;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // Bai03_Sever
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(747, 417);
            Controls.Add(btn_Listen);
            Controls.Add(rtb_Out);
            Name = "Bai03_Sever";
            Text = "Bai03_Sever";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_Out;
        private Button btn_Listen;
    }
}