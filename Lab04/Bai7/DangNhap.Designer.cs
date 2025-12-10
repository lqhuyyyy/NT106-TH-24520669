namespace Bai7
{
    partial class DangNhap
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
            GB1 = new GroupBox();
            TB_Password = new TextBox();
            TB_Username = new TextBox();
            LB_Pass = new Label();
            LB_USN = new Label();
            label1 = new Label();
            BTN_Login = new Button();
            LB_Signup = new Label();
            LLB_SIGNUP = new LinkLabel();
            GB1.SuspendLayout();
            SuspendLayout();
            // 
            // GB1
            // 
            GB1.Controls.Add(TB_Password);
            GB1.Controls.Add(TB_Username);
            GB1.Controls.Add(LB_Pass);
            GB1.Controls.Add(LB_USN);
            GB1.Location = new Point(29, 95);
            GB1.Name = "GB1";
            GB1.Size = new Size(376, 138);
            GB1.TabIndex = 6;
            GB1.TabStop = false;
            GB1.Text = "Login";
            // 
            // TB_Password
            // 
            TB_Password.Location = new Point(103, 79);
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(246, 27);
            TB_Password.TabIndex = 3;
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(103, 36);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(246, 27);
            TB_Username.TabIndex = 2;
            // 
            // LB_Pass
            // 
            LB_Pass.AutoSize = true;
            LB_Pass.Location = new Point(6, 82);
            LB_Pass.Name = "LB_Pass";
            LB_Pass.Size = new Size(70, 20);
            LB_Pass.TabIndex = 1;
            LB_Pass.Text = "Password";
            // 
            // LB_USN
            // 
            LB_USN.AutoSize = true;
            LB_USN.Location = new Point(6, 39);
            LB_USN.Name = "LB_USN";
            LB_USN.Size = new Size(75, 20);
            LB_USN.TabIndex = 0;
            LB_USN.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 21);
            label1.Name = "label1";
            label1.Size = new Size(267, 41);
            label1.TabIndex = 5;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // BTN_Login
            // 
            BTN_Login.Location = new Point(413, 122);
            BTN_Login.Name = "BTN_Login";
            BTN_Login.Size = new Size(94, 88);
            BTN_Login.TabIndex = 7;
            BTN_Login.Text = "LOGIN";
            BTN_Login.UseVisualStyleBackColor = true;
            BTN_Login.Click += BTN_Login_Click;
            // 
            // LB_Signup
            // 
            LB_Signup.AutoSize = true;
            LB_Signup.Location = new Point(132, 246);
            LB_Signup.Name = "LB_Signup";
            LB_Signup.Size = new Size(187, 20);
            LB_Signup.TabIndex = 8;
            LB_Signup.Text = "Don't have an account yet?";
            // 
            // LLB_SIGNUP
            // 
            LLB_SIGNUP.AutoSize = true;
            LLB_SIGNUP.Location = new Point(319, 246);
            LLB_SIGNUP.Name = "LLB_SIGNUP";
            LLB_SIGNUP.Size = new Size(63, 20);
            LLB_SIGNUP.TabIndex = 9;
            LLB_SIGNUP.TabStop = true;
            LLB_SIGNUP.Text = "Đăng ký";
            LLB_SIGNUP.LinkClicked += LLB_SIGNUP_LinkClicked;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 335);
            Controls.Add(LLB_SIGNUP);
            Controls.Add(LB_Signup);
            Controls.Add(BTN_Login);
            Controls.Add(GB1);
            Controls.Add(label1);
            Name = "DangNhap";
            Text = "DangNhap";
            GB1.ResumeLayout(false);
            GB1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GB1;
        private TextBox TB_Password;
        private TextBox TB_Username;
        private Label LB_Pass;
        private Label LB_USN;
        private Label label1;
        private Button BTN_Login;
        private Label LB_Signup;
        private LinkLabel LLB_SIGNUP;
    }
}