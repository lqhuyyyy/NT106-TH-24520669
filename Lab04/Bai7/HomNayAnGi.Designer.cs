namespace Bai7
{
    partial class HomNayAnGi
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
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            TC = new TabControl();
            TP_1 = new TabPage();
            FLP1 = new FlowLayoutPanel();
            TP_2 = new TabPage();
            FLP2 = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            LB1 = new Label();
            LB2 = new Label();
            CB1 = new ComboBox();
            CB2 = new ComboBox();
            PB = new ProgressBar();
            label2 = new Label();
            TC.SuspendLayout();
            TP_1.SuspendLayout();
            TP_2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(267, 41);
            label1.TabIndex = 6;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // button1
            // 
            button1.Location = new Point(487, 31);
            button1.Name = "button1";
            button1.Size = new Size(130, 62);
            button1.TabIndex = 7;
            button1.Text = "Ăn gì giờ?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(643, 31);
            button3.Name = "button3";
            button3.Size = new Size(126, 62);
            button3.TabIndex = 9;
            button3.Text = "Thêm món ăn";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TC
            // 
            TC.Controls.Add(TP_1);
            TC.Controls.Add(TP_2);
            TC.Location = new Point(29, 94);
            TC.Name = "TC";
            TC.SelectedIndex = 0;
            TC.Size = new Size(740, 659);
            TC.TabIndex = 10;
            TC.SelectedIndexChanged += TC_SelectedIndexChanged;
            // 
            // TP_1
            // 
            TP_1.Controls.Add(FLP1);
            TP_1.Location = new Point(4, 29);
            TP_1.Name = "TP_1";
            TP_1.Padding = new Padding(3);
            TP_1.Size = new Size(732, 626);
            TP_1.TabIndex = 0;
            TP_1.Text = "All";
            TP_1.UseVisualStyleBackColor = true;
            // 
            // FLP1
            // 
            FLP1.AutoScroll = true;
            FLP1.Dock = DockStyle.Fill;
            FLP1.FlowDirection = FlowDirection.TopDown;
            FLP1.Location = new Point(3, 3);
            FLP1.Name = "FLP1";
            FLP1.Size = new Size(726, 620);
            FLP1.TabIndex = 1;
            FLP1.WrapContents = false;
            // 
            // TP_2
            // 
            TP_2.Controls.Add(FLP2);
            TP_2.Location = new Point(4, 29);
            TP_2.Name = "TP_2";
            TP_2.Padding = new Padding(3);
            TP_2.Size = new Size(732, 626);
            TP_2.TabIndex = 1;
            TP_2.Text = "Tôi đóng góp";
            TP_2.UseVisualStyleBackColor = true;
            // 
            // FLP2
            // 
            FLP2.AutoScroll = true;
            FLP2.Dock = DockStyle.Fill;
            FLP2.Location = new Point(3, 3);
            FLP2.Name = "FLP2";
            FLP2.Size = new Size(726, 620);
            FLP2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // LB1
            // 
            LB1.AutoSize = true;
            LB1.Location = new Point(531, 775);
            LB1.Name = "LB1";
            LB1.Size = new Size(41, 20);
            LB1.TabIndex = 11;
            LB1.Text = "Page";
            // 
            // LB2
            // 
            LB2.AutoSize = true;
            LB2.Location = new Point(639, 775);
            LB2.Name = "LB2";
            LB2.Size = new Size(70, 20);
            LB2.TabIndex = 12;
            LB2.Text = "Page size";
            // 
            // CB1
            // 
            CB1.FormattingEnabled = true;
            CB1.Location = new Point(581, 772);
            CB1.Name = "CB1";
            CB1.Size = new Size(55, 28);
            CB1.TabIndex = 13;
            CB1.SelectedIndexChanged += CB1_SelectedIndexChanged;
            CB1.KeyDown += CB1_KeyDown;
            // 
            // CB2
            // 
            CB2.FormattingEnabled = true;
            CB2.Location = new Point(710, 772);
            CB2.Name = "CB2";
            CB2.Size = new Size(55, 28);
            CB2.TabIndex = 14;
            CB2.SelectedIndexChanged += CB2_SelectedIndexChanged;
            CB2.KeyDown += CB2_KeyDown;
            // 
            // PB
            // 
            PB.Location = new Point(141, 766);
            PB.Name = "PB";
            PB.Size = new Size(384, 29);
            PB.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 772);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 16;
            label2.Text = "Trạng thái tải:";
            // 
            // HomNayAnGi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 825);
            Controls.Add(label2);
            Controls.Add(PB);
            Controls.Add(CB2);
            Controls.Add(CB1);
            Controls.Add(LB2);
            Controls.Add(LB1);
            Controls.Add(TC);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "HomNayAnGi";
            Text = "Form1";
            Load += HomNayAnGi_Load;
            TC.ResumeLayout(false);
            TP_1.ResumeLayout(false);
            TP_2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button3;
        private TabControl TC;
        private TabPage TP_1;
        private TabPage TP_2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label LB1;
        private Label LB2;
        private ComboBox CB1;
        private ComboBox CB2;
        private FlowLayoutPanel FLP1;
        private FlowLayoutPanel FLP2;
        private ProgressBar PB;
        private Label label2;
    }
}
