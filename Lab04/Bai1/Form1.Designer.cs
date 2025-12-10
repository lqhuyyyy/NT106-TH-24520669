namespace Bai1
{
    partial class Form1
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGetHTML = new System.Windows.Forms.Button();
            this.rtbHTMLContent = new System.Windows.Forms.RichTextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(70, 15);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(450, 22);
            this.txtURL.TabIndex = 0;
            // 
            // btnGetHTML
            // 
            this.btnGetHTML.Location = new System.Drawing.Point(530, 12);
            this.btnGetHTML.Name = "btnGetHTML";
            this.btnGetHTML.Size = new System.Drawing.Size(120, 28);
            this.btnGetHTML.TabIndex = 1;
            this.btnGetHTML.Text = "Get HTML";
            this.btnGetHTML.UseVisualStyleBackColor = true;
            this.btnGetHTML.Click += new System.EventHandler(this.btnGetHTML_Click);
            // 
            // rtbHTMLContent
            // 
            this.rtbHTMLContent.Location = new System.Drawing.Point(15, 55);
            this.rtbHTMLContent.Name = "rtbHTMLContent";
            this.rtbHTMLContent.Size = new System.Drawing.Size(635, 360);
            this.rtbHTMLContent.TabIndex = 2;
            this.rtbHTMLContent.Text = "";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(15, 18);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(42, 16);
            this.lblURL.TabIndex = 3;
            this.lblURL.Text = "URL:";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 430);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.rtbHTMLContent);
            this.Controls.Add(this.btnGetHTML);
            this.Controls.Add(this.txtURL);
            this.Name = "Bai1";
            this.Text = "Get HTML Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGetHTML;
        private System.Windows.Forms.RichTextBox rtbHTMLContent;
        private System.Windows.Forms.Label lblURL;
    }
}