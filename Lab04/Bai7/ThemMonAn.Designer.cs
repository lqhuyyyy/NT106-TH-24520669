namespace Bai7
{
    partial class ThemMonAn
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
            LB1 = new Label();
            label2 = new Label();
            TB_Ten = new TextBox();
            RTB_Mota = new RichTextBox();
            BTN_Clear = new Button();
            BTN_Them = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TB_Gia = new TextBox();
            TB_DiaChi = new TextBox();
            TB_HinhAnh = new TextBox();
            SuspendLayout();
            // 
            // LB1
            // 
            LB1.AutoSize = true;
            LB1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LB1.Location = new Point(127, 21);
            LB1.Name = "LB1";
            LB1.Size = new Size(239, 46);
            LB1.TabIndex = 0;
            LB1.Text = "Thêm món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 86);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên món ăn:";
            // 
            // TB_Ten
            // 
            TB_Ten.Location = new Point(137, 86);
            TB_Ten.Name = "TB_Ten";
            TB_Ten.Size = new Size(313, 27);
            TB_Ten.TabIndex = 2;
            // 
            // RTB_Mota
            // 
            RTB_Mota.Location = new Point(137, 305);
            RTB_Mota.Name = "RTB_Mota";
            RTB_Mota.Size = new Size(313, 158);
            RTB_Mota.TabIndex = 3;
            RTB_Mota.Text = "";
            // 
            // BTN_Clear
            // 
            BTN_Clear.Location = new Point(231, 489);
            BTN_Clear.Name = "BTN_Clear";
            BTN_Clear.Size = new Size(94, 29);
            BTN_Clear.TabIndex = 4;
            BTN_Clear.Text = "Clear";
            BTN_Clear.UseVisualStyleBackColor = true;
            BTN_Clear.Click += BTN_Clear_Click;
            // 
            // BTN_Them
            // 
            BTN_Them.Location = new Point(356, 489);
            BTN_Them.Name = "BTN_Them";
            BTN_Them.Size = new Size(94, 29);
            BTN_Them.TabIndex = 5;
            BTN_Them.Text = "Thêm";
            BTN_Them.UseVisualStyleBackColor = true;
            BTN_Them.Click += BTN_Them_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 128);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 6;
            label1.Text = "Giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 177);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 237);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 8;
            label4.Text = "Hình ảnh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 305);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 9;
            label5.Text = "Mô tả:";
            // 
            // TB_Gia
            // 
            TB_Gia.Location = new Point(137, 125);
            TB_Gia.Name = "TB_Gia";
            TB_Gia.Size = new Size(313, 27);
            TB_Gia.TabIndex = 10;
            // 
            // TB_DiaChi
            // 
            TB_DiaChi.Location = new Point(137, 174);
            TB_DiaChi.Name = "TB_DiaChi";
            TB_DiaChi.Size = new Size(313, 27);
            TB_DiaChi.TabIndex = 11;
            // 
            // TB_HinhAnh
            // 
            TB_HinhAnh.Location = new Point(137, 234);
            TB_HinhAnh.Name = "TB_HinhAnh";
            TB_HinhAnh.Size = new Size(313, 27);
            TB_HinhAnh.TabIndex = 12;
            // 
            // ThemMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 557);
            Controls.Add(TB_HinhAnh);
            Controls.Add(TB_DiaChi);
            Controls.Add(TB_Gia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(BTN_Them);
            Controls.Add(BTN_Clear);
            Controls.Add(RTB_Mota);
            Controls.Add(TB_Ten);
            Controls.Add(label2);
            Controls.Add(LB1);
            Name = "ThemMonAn";
            Text = "ThemMonAn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LB1;
        private Label label2;
        private TextBox TB_Ten;
        private RichTextBox RTB_Mota;
        private Button BTN_Clear;
        private Button BTN_Them;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TB_Gia;
        private TextBox TB_DiaChi;
        private TextBox TB_HinhAnh;
    }
}