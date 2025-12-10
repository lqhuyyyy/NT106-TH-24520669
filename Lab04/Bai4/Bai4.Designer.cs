namespace Lab04
{
    partial class Bai4
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
            splitContainer1 = new SplitContainer();
            flpList = new FlowLayoutPanel();
            progressBar1 = new ProgressBar();
            btnLoad = new Button();
            webBrowser1 = new WebBrowser();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flpList);
            splitContainer1.Panel1.Controls.Add(progressBar1);
            splitContainer1.Panel1.Controls.Add(btnLoad);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(webBrowser1);
            splitContainer1.Size = new Size(1067, 721);
            splitContainer1.SplitterDistance = 347;
            splitContainer1.TabIndex = 0;
            // 
            // flpList
            // 
            flpList.AutoScroll = true;
            flpList.BackColor = Color.WhiteSmoke;
            flpList.Dock = DockStyle.Fill;
            flpList.Location = new Point(0, 56);
            flpList.Margin = new Padding(3, 4, 3, 4);
            flpList.Name = "flpList";
            flpList.Size = new Size(347, 636);
            flpList.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 692);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(347, 29);
            progressBar1.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Firebrick;
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.Dock = DockStyle.Top;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Cambria", 12F, FontStyle.Bold);
            btnLoad.ForeColor = Color.Gold;
            btnLoad.Location = new Point(0, 0);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(347, 56);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Tải danh sách phim";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // webBrowser1
            // 
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Location = new Point(0, 0);
            webBrowser1.Margin = new Padding(3, 4, 3, 4);
            webBrowser1.MinimumSize = new Size(20, 25);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Size = new Size(716, 721);
            webBrowser1.TabIndex = 0;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 721);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bai4";
            Text = "Bài 4: Web Scraping Beta Cinemas";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}