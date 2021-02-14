// * A Basic Netflix Intro Theme
using System;
using System.Windows.Forms;

namespace Netflix
{
    public partial class IntroPage : Form
    {
        // ? Handles External User Interactions
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
        int time = 0;
        public IntroPage()
        {
            InitializeComponent();
            startIntro();
        }
        // ? Loads The Intro Video File
        void startIntro()
        {
            string vidLocation = Environment.CurrentDirectory + @"\Custom UI\Netflix Starting Animation.mp4";
            axMoviePlayer1.FileName = vidLocation;
            Console.WriteLine(axMoviePlayer1.Duration);
            axMoviePlayer1.Play();
            timer1.Interval = 1000;
            timer1.Start();
        }

        // ? Count The Duration Of The Intro And Proceeds TO The Next Form After The Designated Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(time == (int)axMoviePlayer1.Duration)
            {
                axMoviePlayer1.Stop();
                this.Hide();
                StartPage f = new StartPage();
                f.Show();
            }
            time++;
        }

    }
}
