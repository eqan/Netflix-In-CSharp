﻿namespace Netflix
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userID = new System.Windows.Forms.Label();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.logInBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.statusPassword = new System.Windows.Forms.Label();
            this.statusID = new System.Windows.Forms.Label();
            this.statusSymbolPassword = new System.Windows.Forms.PictureBox();
            this.statusSymbolID = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusSymbolPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusSymbolID)).BeginInit();
            this.SuspendLayout();
            // 
            // userID
            // 
            this.userID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userID.AutoSize = true;
            this.userID.Font = new System.Drawing.Font("XXII DONT-MESS-WITH-VIKINGS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID.ForeColor = System.Drawing.Color.White;
            this.userID.Location = new System.Drawing.Point(201, 168);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(63, 21);
            this.userID.TabIndex = 0;
            this.userID.Text = "User ID:";
            // 
            // userIDBox
            // 
            this.userIDBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userIDBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.userIDBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userIDBox.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDBox.ForeColor = System.Drawing.Color.White;
            this.userIDBox.Location = new System.Drawing.Point(315, 168);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.Size = new System.Drawing.Size(290, 15);
            this.userIDBox.TabIndex = 1;
            this.userIDBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userIDBox_MouseClick);
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("XXII DONT-MESS-WITH-VIKINGS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(182, 213);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(82, 21);
            this.password.TabIndex = 2;
            this.password.Text = "Password:";
            // 
            // logInBtn
            // 
            this.logInBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logInBtn.BackColor = System.Drawing.Color.Red;
            this.logInBtn.FlatAppearance.BorderSize = 0;
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBtn.Font = new System.Drawing.Font("XXII DONT-MESS-WITH-VIKINGS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.ForeColor = System.Drawing.Color.White;
            this.logInBtn.Location = new System.Drawing.Point(348, 277);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(109, 48);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "LOGIN";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            this.logInBtn.MouseLeave += new System.EventHandler(this.logInBtn_MouseLeave);
            this.logInBtn.MouseHover += new System.EventHandler(this.logInBtn_MouseHover);
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resetBtn.BackColor = System.Drawing.Color.Red;
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("XXII DONT-MESS-WITH-VIKINGS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(477, 277);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(109, 48);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            this.resetBtn.MouseLeave += new System.EventHandler(this.resetBtn_MouseLeave);
            this.resetBtn.MouseHover += new System.EventHandler(this.resetBtn_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(316, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 3);
            this.label1.TabIndex = 16;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.BackColor = System.Drawing.Color.Black;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.White;
            this.passwordBox.Location = new System.Drawing.Point(315, 213);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(290, 15);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordBox_MouseClick);
            this.passwordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordBox_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(315, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 3);
            this.label2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
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
            // closeBtn
            // 
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(745, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(54, 29);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 22;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.pictureBox3_Click);
            this.closeBtn.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.closeBtn.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // statusPassword
            // 
            this.statusPassword.AutoSize = true;
            this.statusPassword.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPassword.ForeColor = System.Drawing.Color.White;
            this.statusPassword.Location = new System.Drawing.Point(662, 217);
            this.statusPassword.Name = "statusPassword";
            this.statusPassword.Size = new System.Drawing.Size(0, 14);
            this.statusPassword.TabIndex = 30;
            // 
            // statusID
            // 
            this.statusID.AutoSize = true;
            this.statusID.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusID.ForeColor = System.Drawing.Color.White;
            this.statusID.Location = new System.Drawing.Point(663, 170);
            this.statusID.Name = "statusID";
            this.statusID.Size = new System.Drawing.Size(0, 14);
            this.statusID.TabIndex = 29;
            // 
            // statusSymbolPassword
            // 
            this.statusSymbolPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusSymbolPassword.Location = new System.Drawing.Point(618, 201);
            this.statusSymbolPassword.Name = "statusSymbolPassword";
            this.statusSymbolPassword.Size = new System.Drawing.Size(39, 42);
            this.statusSymbolPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusSymbolPassword.TabIndex = 28;
            this.statusSymbolPassword.TabStop = false;
            // 
            // statusSymbolID
            // 
            this.statusSymbolID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusSymbolID.Location = new System.Drawing.Point(618, 153);
            this.statusSymbolID.Name = "statusSymbolID";
            this.statusSymbolID.Size = new System.Drawing.Size(39, 42);
            this.statusSymbolID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusSymbolID.TabIndex = 27;
            this.statusSymbolID.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusPassword);
            this.Controls.Add(this.statusID);
            this.Controls.Add(this.statusSymbolPassword);
            this.Controls.Add(this.statusSymbolID);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userIDBox);
            this.Controls.Add(this.userID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netflix";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusSymbolPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusSymbolID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Label statusPassword;
        private System.Windows.Forms.Label statusID;
        private System.Windows.Forms.PictureBox statusSymbolPassword;
        private System.Windows.Forms.PictureBox statusSymbolID;
    }
}