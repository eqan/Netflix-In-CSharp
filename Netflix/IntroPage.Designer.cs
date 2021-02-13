namespace Netflix
{
    partial class IntroPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroPage));
            this.axMoviePlayer1 = new AxMOVIEPLAYERLib.AxMoviePlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axMoviePlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axMoviePlayer1
            // 
            this.axMoviePlayer1.Enabled = true;
            this.axMoviePlayer1.Location = new System.Drawing.Point(0, -1);
            this.axMoviePlayer1.Name = "axMoviePlayer1";
            this.axMoviePlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMoviePlayer1.OcxState")));
            this.axMoviePlayer1.Size = new System.Drawing.Size(801, 451);
            this.axMoviePlayer1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IntroPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axMoviePlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntroPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntroPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.axMoviePlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMOVIEPLAYERLib.AxMoviePlayer axMoviePlayer1;
        private System.Windows.Forms.Timer timer1;
    }
}