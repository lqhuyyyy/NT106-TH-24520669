namespace Bai6
{
    partial class Bai6_ViewMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai6_ViewMail));
            textbox_from = new TextBox();
            textbox_to = new TextBox();
            reply = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label_Subject = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // textbox_from
            // 
            textbox_from.BackColor = SystemColors.GradientInactiveCaption;
            textbox_from.Font = new Font("Microsoft Sans Serif", 10.8F);
            textbox_from.Location = new Point(90, 20);
            textbox_from.Name = "textbox_from";
            textbox_from.ReadOnly = true;
            textbox_from.Size = new Size(302, 28);
            textbox_from.TabIndex = 1;
            // 
            // textbox_to
            // 
            textbox_to.BackColor = SystemColors.GradientInactiveCaption;
            textbox_to.Font = new Font("Microsoft Sans Serif", 10.8F);
            textbox_to.Location = new Point(90, 48);
            textbox_to.Name = "textbox_to";
            textbox_to.ReadOnly = true;
            textbox_to.Size = new Size(302, 28);
            textbox_to.TabIndex = 2;
            // 
            // reply
            // 
            reply.BackColor = Color.Transparent;
            reply.FlatAppearance.BorderColor = Color.SkyBlue;
            reply.FlatAppearance.BorderSize = 3;
            reply.FlatStyle = FlatStyle.Flat;
            reply.Font = new Font("Cambria", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            reply.Location = new Point(437, 20);
            reply.Name = "reply";
            reply.Size = new Size(100, 56);
            reply.TabIndex = 3;
            reply.Text = "REPLY";
            reply.UseVisualStyleBackColor = false;
            reply.Click += reply_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 120);
            webView21.Name = "webView21";
            webView21.Size = new Size(538, 550);
            webView21.TabIndex = 4;
            webView21.ZoomFactor = 1D;
            // 
            // label_Subject
            // 
            label_Subject.AutoSize = true;
            label_Subject.BackColor = Color.Transparent;
            label_Subject.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Subject.Location = new Point(12, 92);
            label_Subject.Name = "label_Subject";
            label_Subject.Size = new Size(85, 25);
            label_Subject.TabIndex = 5;
            label_Subject.Text = "Subject";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 11F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(60, 24);
            label1.TabIndex = 6;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.Location = new Point(34, 52);
            label2.Name = "label2";
            label2.Size = new Size(38, 24);
            label2.TabIndex = 6;
            label2.Text = "To:";
            label2.Click += label2_Click;
            // 
            // Bai6_ViewMail
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(562, 682);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_Subject);
            Controls.Add(webView21);
            Controls.Add(reply);
            Controls.Add(textbox_to);
            Controls.Add(textbox_from);
            Name = "Bai6_ViewMail";
            Text = "Read Mail";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TextBox textbox_from;
        private System.Windows.Forms.TextBox textbox_to;
        private System.Windows.Forms.Button reply;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label label_Subject;
        private Label label1;
        private Label label2;
    }
}