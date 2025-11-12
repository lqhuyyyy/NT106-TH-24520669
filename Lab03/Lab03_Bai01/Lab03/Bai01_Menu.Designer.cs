namespace Lab03
{
    partial class Bai01_Menu
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
            btn_SV = new Button();
            btn_CL = new Button();
            SuspendLayout();
            // 
            // btn_SV
            // 
            btn_SV.BackColor = Color.FromArgb(160, 255, 255, 255);
            btn_SV.FlatAppearance.BorderSize = 0;
            btn_SV.FlatStyle = FlatStyle.Flat;
            btn_SV.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            btn_SV.ForeColor = Color.FromArgb(30, 60, 60);
            btn_SV.Location = new Point(234, 172);
            btn_SV.Name = "btn_SV";
            btn_SV.Size = new Size(179, 85);
            btn_SV.TabIndex = 1;
            btn_SV.Text = "Sever";
            btn_SV.UseVisualStyleBackColor = false;
            btn_SV.Click += btn_SV_Click;
            // 
            // btn_CL
            // 
            btn_CL.BackColor = Color.FromArgb(160, 255, 255, 255);
            btn_CL.FlatAppearance.BorderSize = 0;
            btn_CL.FlatStyle = FlatStyle.Flat;
            btn_CL.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            btn_CL.ForeColor = Color.FromArgb(30, 60, 60);
            btn_CL.Location = new Point(639, 172);
            btn_CL.Name = "btn_CL";
            btn_CL.Size = new Size(179, 85);
            btn_CL.TabIndex = 1;
            btn_CL.Text = "Client";
            btn_CL.UseVisualStyleBackColor = false;
            btn_CL.Click += btn_CL_Click;
            // 
            // Lab03_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            BackgroundImage = Lab03_Bai01.Properties.Resources.mountain;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1053, 480);
            Controls.Add(btn_CL);
            Controls.Add(btn_SV);
            Name = "Lab03_Bai01";
            Text = "Lab03_Bai01";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_SV;
        private Button btn_CL;
    }
}