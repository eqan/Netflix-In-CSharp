namespace Netflix
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.movieLabel = new System.Windows.Forms.Label();
            this.AudiencWatchLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.PictureBox();
            this.likedVideosBtn = new System.Windows.Forms.PictureBox();
            this.menuItem1 = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.PictureBox();
            this.historyBtn = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Maximize = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedVideosBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(120, 281);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(765, 263);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(391, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 238);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(862, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(123, 88);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Typold Extended Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "SERIES";
            // 
            // movieLabel
            // 
            this.movieLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("XXII DONT-MESS-WITH-VIKINGS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLabel.ForeColor = System.Drawing.Color.White;
            this.movieLabel.Location = new System.Drawing.Point(120, 129);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(200, 49);
            this.movieLabel.TabIndex = 28;
            this.movieLabel.Text = "Movie Title";
            // 
            // AudiencWatchLabel
            // 
            this.AudiencWatchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AudiencWatchLabel.AutoSize = true;
            this.AudiencWatchLabel.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudiencWatchLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.AudiencWatchLabel.Location = new System.Drawing.Point(126, 178);
            this.AudiencWatchLabel.Name = "AudiencWatchLabel";
            this.AudiencWatchLabel.Size = new System.Drawing.Size(92, 21);
            this.AudiencWatchLabel.TabIndex = 29;
            this.AudiencWatchLabel.Text = "97% Match";
            // 
            // yearLabel
            // 
            this.yearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.yearLabel.AutoSize = true;
            this.yearLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yearLabel.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.yearLabel.Location = new System.Drawing.Point(224, 178);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(43, 21);
            this.yearLabel.TabIndex = 30;
            this.yearLabel.Text = "Year";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.CausesValidation = false;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.95F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(129, 202);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(256, 89);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "After selling his soul to save a loved one, daredevil biker Johnny Blaze pays the" +
    " price by becoming a flame-skulled bounty hunter for Mephistopheles";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.settingsBtn);
            this.panel3.Controls.Add(this.likedVideosBtn);
            this.panel3.Controls.Add(this.menuItem1);
            this.panel3.Controls.Add(this.profileBtn);
            this.panel3.Controls.Add(this.historyBtn);
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Controls.Add(this.homeBtn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 544);
            this.panel3.TabIndex = 32;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.Location = new System.Drawing.Point(31, 485);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.settingsBtn.Size = new System.Drawing.Size(66, 26);
            this.settingsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsBtn.TabIndex = 9;
            this.settingsBtn.TabStop = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            this.settingsBtn.MouseLeave += new System.EventHandler(this.settingsBtn_MouseLeave);
            this.settingsBtn.MouseHover += new System.EventHandler(this.settingsBtn_MouseHover);
            // 
            // likedVideosBtn
            // 
            this.likedVideosBtn.Image = ((System.Drawing.Image)(resources.GetObject("likedVideosBtn.Image")));
            this.likedVideosBtn.Location = new System.Drawing.Point(49, 297);
            this.likedVideosBtn.Name = "likedVideosBtn";
            this.likedVideosBtn.Size = new System.Drawing.Size(37, 26);
            this.likedVideosBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.likedVideosBtn.TabIndex = 8;
            this.likedVideosBtn.TabStop = false;
            this.likedVideosBtn.Click += new System.EventHandler(this.likedVideosBtn_Click);
            this.likedVideosBtn.MouseLeave += new System.EventHandler(this.likedVideosBtn_MouseLeave);
            this.likedVideosBtn.MouseHover += new System.EventHandler(this.likedVideosBtn_MouseHover);
            // 
            // menuItem1
            // 
            this.menuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuItem1.FlatAppearance.BorderSize = 0;
            this.menuItem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuItem1.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem1.ForeColor = System.Drawing.Color.White;
            this.menuItem1.Location = new System.Drawing.Point(32, 460);
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(0, 0);
            this.menuItem1.TabIndex = 7;
            this.menuItem1.UseVisualStyleBackColor = false;
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
            this.profileBtn.Location = new System.Drawing.Point(48, 354);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(37, 26);
            this.profileBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileBtn.TabIndex = 3;
            this.profileBtn.TabStop = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            this.profileBtn.MouseLeave += new System.EventHandler(this.profileBtn_MouseLeave);
            this.profileBtn.MouseHover += new System.EventHandler(this.profileBtn_MouseHover);
            // 
            // historyBtn
            // 
            this.historyBtn.Image = ((System.Drawing.Image)(resources.GetObject("historyBtn.Image")));
            this.historyBtn.Location = new System.Drawing.Point(48, 244);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(37, 27);
            this.historyBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.historyBtn.TabIndex = 2;
            this.historyBtn.TabStop = false;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            this.historyBtn.MouseLeave += new System.EventHandler(this.historyBtn_MouseLeave);
            this.historyBtn.MouseHover += new System.EventHandler(this.historyBtn_MouseHover);
            // 
            // searchBtn
            // 
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(48, 193);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(37, 25);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchBtn.TabIndex = 1;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            this.searchBtn.MouseLeave += new System.EventHandler(this.searchBtn_MouseLeave);
            this.searchBtn.MouseHover += new System.EventHandler(this.searchBtn_MouseHover);
            // 
            // homeBtn
            // 
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(48, 135);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(37, 27);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 0;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.Maximize);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Location = new System.Drawing.Point(751, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 26);
            this.panel1.TabIndex = 35;
            // 
            // Close
            // 
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(96, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(45, 23);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 26;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.closebtn_Click);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // Maximize
            // 
            this.Maximize.Image = ((System.Drawing.Image)(resources.GetObject("Maximize.Image")));
            this.Maximize.Location = new System.Drawing.Point(52, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(44, 23);
            this.Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximize.TabIndex = 27;
            this.Maximize.TabStop = false;
            this.Maximize.Click += new System.EventHandler(this.maximizeBtn_Click);
            this.Maximize.MouseLeave += new System.EventHandler(this.Maximize_MouseLeave);
            this.Maximize.MouseHover += new System.EventHandler(this.Maximize_MouseHover);
            // 
            // Minimize
            // 
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(8, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(44, 23);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 28;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.minimizebtn_Click);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            this.Minimize.MouseHover += new System.EventHandler(this.Minimize_MouseHover);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(888, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.AudiencWatchLabel);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedVideosBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label AudiencWatchLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox likedVideosBtn;
        private System.Windows.Forms.Button menuItem1;
        private System.Windows.Forms.PictureBox profileBtn;
        private System.Windows.Forms.PictureBox historyBtn;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.PictureBox settingsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Maximize;
        private System.Windows.Forms.PictureBox Minimize;
    }
}