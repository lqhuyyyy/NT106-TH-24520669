namespace Bai1
{
    partial class Form1
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
            TB_Body = new TextBox();
            TB_Sub = new TextBox();
            TB_To = new TextBox();
            TB_From = new TextBox();
            BTN_Send = new Button();
            LB_Body = new Label();
            LB_Subject = new Label();
            LB_To = new Label();
            LB_From = new Label();
            SuspendLayout();
            // 
            // TB_Body
            // 
            TB_Body.Location = new Point(152, 148);
            TB_Body.Multiline = true;
            TB_Body.Name = "TB_Body";
            TB_Body.Size = new Size(620, 286);
            TB_Body.TabIndex = 17;
            // 
            // TB_Sub
            // 
            TB_Sub.Location = new Point(152, 108);
            TB_Sub.Name = "TB_Sub";
            TB_Sub.Size = new Size(620, 27);
            TB_Sub.TabIndex = 16;
            // 
            // TB_To
            // 
            TB_To.Location = new Point(218, 57);
            TB_To.Name = "TB_To";
            TB_To.Size = new Size(292, 27);
            TB_To.TabIndex = 15;
            // 
            // TB_From
            // 
            TB_From.Location = new Point(218, 17);
            TB_From.Name = "TB_From";
            TB_From.ReadOnly = true;
            TB_From.Size = new Size(292, 27);
            TB_From.TabIndex = 14;
            TB_From.Text = "taonekmay09112005@gmail.com";
            // 
            // BTN_Send
            // 
            BTN_Send.Location = new Point(28, 20);
            BTN_Send.Name = "BTN_Send";
            BTN_Send.Size = new Size(94, 60);
            BTN_Send.TabIndex = 13;
            BTN_Send.Text = "SEND";
            BTN_Send.UseVisualStyleBackColor = true;
            BTN_Send.Click += BTN_Send_Click;
            // 
            // LB_Body
            // 
            LB_Body.AutoSize = true;
            LB_Body.Location = new Point(28, 148);
            LB_Body.Name = "LB_Body";
            LB_Body.Size = new Size(46, 20);
            LB_Body.TabIndex = 12;
            LB_Body.Text = "Body:";
            // 
            // LB_Subject
            // 
            LB_Subject.AutoSize = true;
            LB_Subject.Location = new Point(28, 115);
            LB_Subject.Name = "LB_Subject";
            LB_Subject.Size = new Size(61, 20);
            LB_Subject.TabIndex = 11;
            LB_Subject.Text = "Subject:";
            // 
            // LB_To
            // 
            LB_To.AutoSize = true;
            LB_To.Location = new Point(152, 60);
            LB_To.Name = "LB_To";
            LB_To.Size = new Size(28, 20);
            LB_To.TabIndex = 10;
            LB_To.Text = "To:";
            // 
            // LB_From
            // 
            LB_From.AutoSize = true;
            LB_From.Location = new Point(152, 20);
            LB_From.Name = "LB_From";
            LB_From.Size = new Size(46, 20);
            LB_From.TabIndex = 9;
            LB_From.Text = "From:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TB_Body);
            Controls.Add(TB_Sub);
            Controls.Add(TB_To);
            Controls.Add(TB_From);
            Controls.Add(BTN_Send);
            Controls.Add(LB_Body);
            Controls.Add(LB_Subject);
            Controls.Add(LB_To);
            Controls.Add(LB_From);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Body;
        private TextBox TB_Sub;
        private TextBox TB_To;
        private TextBox TB_From;
        private Button BTN_Send;
        private Label LB_Body;
        private Label LB_Subject;
        private Label LB_To;
        private Label LB_From;
    }
}
