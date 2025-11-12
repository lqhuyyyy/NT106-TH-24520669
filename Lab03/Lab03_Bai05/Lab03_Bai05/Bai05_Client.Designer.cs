namespace Lab03_Bai05
{
    partial class Bai05_Client
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
            btnRand = new Button();
            btnDisconnect = new Button();
            btnAddDish = new Button();
            btnAddPicDish = new Button();
            btnConnect = new Button();
            tbIDDish = new TextBox();
            label5 = new Label();
            label2 = new Label();
            tbNameDish = new TextBox();
            label3 = new Label();
            tbPicDish = new TextBox();
            label4 = new Label();
            tbIDUser = new TextBox();
            label6 = new Label();
            tbNameUser = new TextBox();
            label7 = new Label();
            tbAthorUser = new TextBox();
            rtbOut = new RichTextBox();
            btnRandAll = new Button();
            SuspendLayout();
            // 
            // btnRand
            // 
            btnRand.Font = new Font("Cambria", 13.8F);
            btnRand.Location = new Point(1013, 510);
            btnRand.Name = "btnRand";
            btnRand.Size = new Size(164, 70);
            btnRand.TabIndex = 3;
            btnRand.Text = "Random 🎲";
            btnRand.UseVisualStyleBackColor = true;
            btnRand.Click += btnRand_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Font = new Font("Cambria", 13.8F);
            btnDisconnect.Location = new Point(774, 520);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(194, 50);
            btnDisconnect.TabIndex = 3;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnAddDish
            // 
            btnAddDish.Font = new Font("Cambria", 13.8F);
            btnAddDish.Location = new Point(534, 520);
            btnAddDish.Name = "btnAddDish";
            btnAddDish.Size = new Size(194, 50);
            btnAddDish.TabIndex = 3;
            btnAddDish.Text = "Thêm món ăn";
            btnAddDish.UseVisualStyleBackColor = true;
            btnAddDish.Click += btnAddDish_Click;
            // 
            // btnAddPicDish
            // 
            btnAddPicDish.Font = new Font("Cambria", 13.8F);
            btnAddPicDish.Location = new Point(304, 520);
            btnAddPicDish.Name = "btnAddPicDish";
            btnAddPicDish.Size = new Size(194, 50);
            btnAddPicDish.TabIndex = 3;
            btnAddPicDish.Text = "Thêm ảnh món";
            btnAddPicDish.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Cambria", 13.8F);
            btnConnect.Location = new Point(69, 520);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(194, 50);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // tbIDDish
            // 
            tbIDDish.Font = new Font("Cambria", 13.8F);
            tbIDDish.Location = new Point(198, 71);
            tbIDDish.Name = "tbIDDish";
            tbIDDish.Size = new Size(263, 34);
            tbIDDish.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AntiqueWhite;
            label5.Font = new Font("Cambria", 13.8F);
            label5.Location = new Point(25, 71);
            label5.Name = "label5";
            label5.Size = new Size(123, 27);
            label5.TabIndex = 8;
            label5.Text = "ID món ăn: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Cambria", 13.8F);
            label2.Location = new Point(25, 129);
            label2.Name = "label2";
            label2.Size = new Size(137, 27);
            label2.TabIndex = 8;
            label2.Text = "Tên món ăn: ";
            // 
            // tbNameDish
            // 
            tbNameDish.Font = new Font("Cambria", 13.8F);
            tbNameDish.Location = new Point(198, 129);
            tbNameDish.Name = "tbNameDish";
            tbNameDish.Size = new Size(263, 34);
            tbNameDish.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Cambria", 13.8F);
            label3.Location = new Point(25, 179);
            label3.Name = "label3";
            label3.Size = new Size(141, 27);
            label3.TabIndex = 8;
            label3.Text = "Ảnh món ăn: ";
            // 
            // tbPicDish
            // 
            tbPicDish.Font = new Font("Cambria", 13.8F);
            tbPicDish.Location = new Point(198, 179);
            tbPicDish.Name = "tbPicDish";
            tbPicDish.ReadOnly = true;
            tbPicDish.Size = new Size(263, 34);
            tbPicDish.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Cambria", 13.8F);
            label4.Location = new Point(25, 274);
            label4.Name = "label4";
            label4.Size = new Size(158, 27);
            label4.TabIndex = 8;
            label4.Text = "ID người dùng:";
            // 
            // tbIDUser
            // 
            tbIDUser.Font = new Font("Cambria", 13.8F);
            tbIDUser.Location = new Point(198, 274);
            tbIDUser.Name = "tbIDUser";
            tbIDUser.Size = new Size(263, 34);
            tbIDUser.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AntiqueWhite;
            label6.Font = new Font("Cambria", 13.8F);
            label6.Location = new Point(25, 331);
            label6.Name = "label6";
            label6.Size = new Size(111, 27);
            label6.TabIndex = 8;
            label6.Text = "Họ và tên:";
            // 
            // tbNameUser
            // 
            tbNameUser.Font = new Font("Cambria", 13.8F);
            tbNameUser.Location = new Point(198, 331);
            tbNameUser.Name = "tbNameUser";
            tbNameUser.Size = new Size(263, 34);
            tbNameUser.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AntiqueWhite;
            label7.Font = new Font("Cambria", 13.8F);
            label7.Location = new Point(25, 391);
            label7.Name = "label7";
            label7.Size = new Size(124, 27);
            label7.TabIndex = 8;
            label7.Text = "Quyền hạn:";
            // 
            // tbAthorUser
            // 
            tbAthorUser.Font = new Font("Cambria", 13.8F);
            tbAthorUser.Location = new Point(198, 391);
            tbAthorUser.Name = "tbAthorUser";
            tbAthorUser.Size = new Size(263, 34);
            tbAthorUser.TabIndex = 9;
            // 
            // rtbOut
            // 
            rtbOut.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbOut.Location = new Point(617, 44);
            rtbOut.Name = "rtbOut";
            rtbOut.Size = new Size(731, 412);
            rtbOut.TabIndex = 10;
            rtbOut.Text = "";
            // 
            // btnRandAll
            // 
            btnRandAll.Font = new Font("Cambria", 13.8F);
            btnRandAll.Location = new Point(1212, 510);
            btnRandAll.Name = "btnRandAll";
            btnRandAll.Size = new Size(179, 70);
            btnRandAll.TabIndex = 3;
            btnRandAll.Text = "Random All 🎲";
            btnRandAll.UseVisualStyleBackColor = true;
            btnRandAll.Click += btnRandAll_Click;
            // 
            // Bai05_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1415, 615);
            Controls.Add(rtbOut);
            Controls.Add(tbAthorUser);
            Controls.Add(tbNameUser);
            Controls.Add(tbIDUser);
            Controls.Add(tbPicDish);
            Controls.Add(tbNameDish);
            Controls.Add(tbIDDish);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(btnRandAll);
            Controls.Add(btnRand);
            Controls.Add(btnConnect);
            Controls.Add(btnAddPicDish);
            Controls.Add(btnAddDish);
            Controls.Add(btnDisconnect);
            Name = "Bai05_Client";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRand;
        private Button btnDisconnect;
        private Button btnAddDish;
        private Button btnAddPicDish;
        private Button btnConnect;
        private TextBox tbIDDish;
        private Label label5;
        private Label label2;
        private TextBox tbNameDish;
        private Label label3;
        private TextBox tbPicDish;
        private Label label4;
        private TextBox tbIDUser;
        private Label label6;
        private TextBox tbNameUser;
        private Label label7;
        private TextBox tbAthorUser;
        private RichTextBox rtbOut;
        private Button btnRandAll;
    }
}

        