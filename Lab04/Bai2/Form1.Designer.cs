using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai2
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
            TB_Web = new TextBox();
            TB_Save = new TextBox();
            RTB_html = new RichTextBox();
            BTN_Download = new Button();
            SuspendLayout();
            // 
            // TB_Web
            // 
            TB_Web.Location = new Point(26, 12);
            TB_Web.Name = "TB_Web";
            TB_Web.PlaceholderText = "Nhập địa chỉ web muốn download html";
            TB_Web.Size = new Size(640, 27);
            TB_Web.TabIndex = 0;
            // 
            // TB_Save
            // 
            TB_Save.Location = new Point(26, 54);
            TB_Save.Name = "TB_Save";
            TB_Save.PlaceholderText = "Nhập theo cú pháp E:\\ hoặc C:\\tenfile.html";
            TB_Save.Size = new Size(640, 27);
            TB_Save.TabIndex = 1;
            // 
            // RTB_html
            // 
            RTB_html.Location = new Point(26, 97);
            RTB_html.Name = "RTB_html";
            RTB_html.ScrollBars = RichTextBoxScrollBars.Vertical;
            RTB_html.Size = new Size(747, 326);
            RTB_html.TabIndex = 2;
            RTB_html.Text = "";
            // 
            // BTN_Download
            // 
            BTN_Download.Location = new Point(679, 12);
            BTN_Download.Name = "BTN_Download";
            BTN_Download.Size = new Size(94, 29);
            BTN_Download.TabIndex = 3;
            BTN_Download.Text = "Download";
            BTN_Download.UseVisualStyleBackColor = true;
            BTN_Download.Click += BTN_Download_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_Download);
            Controls.Add(RTB_html);
            Controls.Add(TB_Save);
            Controls.Add(TB_Web);
            Name = "Form1";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Web;
        private TextBox TB_Save;
        private RichTextBox RTB_html;
        private Button BTN_Download;
    }
}
