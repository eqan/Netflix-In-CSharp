using System;
using System.Windows.Forms;
using System.Drawing;

namespace Netflix
{
    public partial class StartPage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public StartPage()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.BackGroundWallPaer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUP f = new SignUP();
            f.Show();
        }

        private void SignUpBtn_MouseHover(object sender, EventArgs e)
        {
            SignUpBtn.BackColor = Color.RoyalBlue;
        }

        private void SignUpBtn_MouseLeave(object sender, EventArgs e)
        {
            SignUpBtn.BackColor = Color.Red;
        }

        private void logOutBtn_MouseHover(object sender, EventArgs e)
        {
            logOutBtn.BackColor = Color.RoyalBlue;
        }

        private void logOutBtn_MouseLeave(object sender, EventArgs e)
        {
            logOutBtn.BackColor = Color.Red;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Red;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
