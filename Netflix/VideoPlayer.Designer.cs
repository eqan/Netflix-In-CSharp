namespace Netflix
{
    partial class VideoPlayer
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
            try
            {
            base.Dispose(disposing);
            }
            catch
            {
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayer));
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.volumeControl = new System.Windows.Forms.TrackBar();
            this.likeBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.volumePercentage = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.PictureBox();
            this.previousBtn = new System.Windows.Forms.PictureBox();
            this.reverseBtn = new System.Windows.Forms.PictureBox();
            this.fastForwardBtn = new System.Windows.Forms.PictureBox();
            this.playPauseBtn = new System.Windows.Forms.PictureBox();
            this.fullScreenBtn = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuItem1 = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.PictureBox();
            this.profileBtn = new System.Windows.Forms.PictureBox();
            this.historyBtn = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.axMoviePlayer1 = new AxMOVIEPLAYERLib.AxMoviePlayer();
            this.currentDuration = new System.Windows.Forms.TextBox();
            this.totalDuration = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likeBtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reverseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastForwardBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPauseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullScreenBtn)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMoviePlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(111, 494);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(749, 123);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalDuration);
            this.panel1.Controls.Add(this.currentDuration);
            this.panel1.Controls.Add(this.volumeControl);
            this.panel1.Controls.Add(this.likeBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.previousBtn);
            this.panel1.Controls.Add(this.reverseBtn);
            this.panel1.Controls.Add(this.fastForwardBtn);
            this.panel1.Controls.Add(this.playPauseBtn);
            this.panel1.Location = new System.Drawing.Point(111, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 74);
            this.panel1.TabIndex = 2;
            // 
            // volumeControl
            // 
            this.volumeControl.AutoSize = false;
            this.volumeControl.Location = new System.Drawing.Point(550, 19);
            this.volumeControl.Maximum = 10000;
            this.volumeControl.Name = "volumeControl";
            this.volumeControl.Size = new System.Drawing.Size(127, 27);
            this.volumeControl.TabIndex = 24;
            this.volumeControl.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeControl.Scroll += new System.EventHandler(this.volume_Scroll);
            // 
            // likeBtn
            // 
            this.likeBtn.Location = new System.Drawing.Point(57, 8);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.Size = new System.Drawing.Size(74, 38);
            this.likeBtn.TabIndex = 10;
            this.likeBtn.TabStop = false;
            this.likeBtn.Click += new System.EventHandler(this.likeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.volumePercentage);
            this.panel2.Location = new System.Drawing.Point(570, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 13);
            this.panel2.TabIndex = 9;
            // 
            // volumePercentage
            // 
            this.volumePercentage.AutoSize = true;
            this.volumePercentage.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumePercentage.ForeColor = System.Drawing.Color.White;
            this.volumePercentage.Location = new System.Drawing.Point(51, -4);
            this.volumePercentage.Name = "volumePercentage";
            this.volumePercentage.Size = new System.Drawing.Size(43, 17);
            this.volumePercentage.TabIndex = 3;
            this.volumePercentage.Text = "100%";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(457, 8);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(74, 38);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.TabStop = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(137, 8);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(74, 38);
            this.previousBtn.TabIndex = 6;
            this.previousBtn.TabStop = false;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // reverseBtn
            // 
            this.reverseBtn.Location = new System.Drawing.Point(217, 8);
            this.reverseBtn.Name = "reverseBtn";
            this.reverseBtn.Size = new System.Drawing.Size(74, 38);
            this.reverseBtn.TabIndex = 5;
            this.reverseBtn.TabStop = false;
            this.reverseBtn.Click += new System.EventHandler(this.reverseBtn_Click);
            // 
            // fastForwardBtn
            // 
            this.fastForwardBtn.Location = new System.Drawing.Point(377, 8);
            this.fastForwardBtn.Name = "fastForwardBtn";
            this.fastForwardBtn.Size = new System.Drawing.Size(74, 38);
            this.fastForwardBtn.TabIndex = 4;
            this.fastForwardBtn.TabStop = false;
            this.fastForwardBtn.Click += new System.EventHandler(this.fastForwardBtn_Click);
            // 
            // playPauseBtn
            // 
            this.playPauseBtn.Location = new System.Drawing.Point(297, 8);
            this.playPauseBtn.Name = "playPauseBtn";
            this.playPauseBtn.Size = new System.Drawing.Size(74, 38);
            this.playPauseBtn.TabIndex = 3;
            this.playPauseBtn.TabStop = false;
            this.playPauseBtn.Click += new System.EventHandler(this.playPauseBtn_Click);
            // 
            // fullScreenBtn
            // 
            this.fullScreenBtn.BackColor = System.Drawing.Color.Transparent;
            this.fullScreenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fullScreenBtn.Location = new System.Drawing.Point(794, 340);
            this.fullScreenBtn.Name = "fullScreenBtn";
            this.fullScreenBtn.Size = new System.Drawing.Size(24, 24);
            this.fullScreenBtn.TabIndex = 3;
            this.fullScreenBtn.TabStop = false;
            this.fullScreenBtn.Click += new System.EventHandler(this.fullScreenBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("XXII DONT-MESS-WITH-VIKINGS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(407, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(135, 33);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Movie Title";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(364, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 3);
            this.label1.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.menuItem1);
            this.panel3.Controls.Add(this.settingsBtn);
            this.panel3.Controls.Add(this.profileBtn);
            this.panel3.Controls.Add(this.historyBtn);
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Controls.Add(this.homeBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 617);
            this.panel3.TabIndex = 19;
            // 
            // menuItem1
            // 
            this.menuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuItem1.FlatAppearance.BorderSize = 0;
            this.menuItem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuItem1.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem1.ForeColor = System.Drawing.Color.White;
            this.menuItem1.Location = new System.Drawing.Point(32, 539);
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(0, 0);
            this.menuItem1.TabIndex = 7;
            this.menuItem1.UseVisualStyleBackColor = false;
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.Location = new System.Drawing.Point(32, 567);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(0, 50, 0, 50);
            this.settingsBtn.Size = new System.Drawing.Size(66, 26);
            this.settingsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsBtn.TabIndex = 6;
            this.settingsBtn.TabStop = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            this.settingsBtn.MouseLeave += new System.EventHandler(this.settingsBtn_MouseLeave);
            this.settingsBtn.MouseHover += new System.EventHandler(this.settingsBtn_MouseHover);
            // 
            // profileBtn
            // 
            this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
            this.profileBtn.Location = new System.Drawing.Point(48, 366);
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
            this.historyBtn.Location = new System.Drawing.Point(48, 312);
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
            this.searchBtn.Location = new System.Drawing.Point(48, 262);
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
            this.homeBtn.Location = new System.Drawing.Point(48, 204);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(37, 27);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 0;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            this.homeBtn.MouseLeave += new System.EventHandler(this.homeBtn_MouseLeave);
            this.homeBtn.MouseHover += new System.EventHandler(this.homeBtn_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(812, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(120, 387);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(668, 21);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(48, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 5);
            this.label2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(48, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 5);
            this.label3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(48, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 5);
            this.label4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(48, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 5);
            this.label5.TabIndex = 18;
            // 
            // axMoviePlayer1
            // 
            this.axMoviePlayer1.Enabled = true;
            this.axMoviePlayer1.Location = new System.Drawing.Point(111, 104);
            this.axMoviePlayer1.Name = "axMoviePlayer1";
            this.axMoviePlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMoviePlayer1.OcxState")));
            this.axMoviePlayer1.Size = new System.Drawing.Size(677, 270);
            this.axMoviePlayer1.TabIndex = 0;
            // 
            // currentDuration
            // 
            this.currentDuration.BackColor = System.Drawing.Color.Black;
            this.currentDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentDuration.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDuration.ForeColor = System.Drawing.Color.White;
            this.currentDuration.Location = new System.Drawing.Point(9, 0);
            this.currentDuration.Name = "currentDuration";
            this.currentDuration.Size = new System.Drawing.Size(45, 15);
            this.currentDuration.TabIndex = 25;
            this.currentDuration.Text = "00:00:00";
            // 
            // totalDuration
            // 
            this.totalDuration.BackColor = System.Drawing.Color.Black;
            this.totalDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalDuration.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDuration.ForeColor = System.Drawing.Color.White;
            this.totalDuration.Location = new System.Drawing.Point(632, 0);
            this.totalDuration.Name = "totalDuration";
            this.totalDuration.Size = new System.Drawing.Size(45, 15);
            this.totalDuration.TabIndex = 26;
            this.totalDuration.Text = "00:00:00";
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(872, 617);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.fullScreenBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.axMoviePlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VideoPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoPlayBack";
            this.Load += new System.EventHandler(this.VideoPlayBack_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likeBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reverseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastForwardBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPauseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullScreenBtn)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMoviePlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox playPauseBtn;
        private System.Windows.Forms.PictureBox nextBtn;
        private System.Windows.Forms.PictureBox previousBtn;
        private System.Windows.Forms.PictureBox reverseBtn;
        private System.Windows.Forms.PictureBox fastForwardBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label volumePercentage;
        private System.Windows.Forms.PictureBox fullScreenBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox profileBtn;
        private System.Windows.Forms.PictureBox historyBtn;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox likeBtn;
        private System.Windows.Forms.Button menuItem1;
        private System.Windows.Forms.PictureBox settingsBtn;
        private AxMOVIEPLAYERLib.AxMoviePlayer axMoviePlayer1;
        private System.Windows.Forms.TrackBar volumeControl;
        private System.Windows.Forms.TextBox totalDuration;
        private System.Windows.Forms.TextBox currentDuration;
    }
}