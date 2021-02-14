/// Summary
/**
    * * A Class That Handles General Account Information
    * TODO: Code Enhancement
 */
using System.Windows.Forms;
using System.Drawing;
using System;

namespace Netflix
{
    public partial class AccountInfo : Form
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

        // ? Labels Made For Transition Effects While Hovering Or Selected
        Label label2, label3, label4, label5, label6;
        string userName, accountName;
        int profileIndex = 1, numberOfVideos;
        bool isCollapsed = false;
        public AccountInfo(string userName, string accountName, int index)
        {
            this.userName = userName;
            this.accountName = accountName;
            this.profileIndex = index;
            InitializeComponent();
            initializeLabels();
            importInformation();
        }
        public AccountInfo(string userName, string accountName, int index, int numberOfVideos)
        {
            this.userName = userName;
            this.accountName = accountName;
            this.profileIndex = index;
            this.numberOfVideos = numberOfVideos;
            InitializeComponent();
            initializeLabels();
            importInformation();
        }
        void initializeLabels()
        {
            label2 = new Label();
            label2.Location = new Point(homeBtn.Location.X, homeBtn.Location.Y + 35);
            this.Controls.Add(label2);
            label2.BringToFront();
            label3 = new Label();
            label3.Location = new Point(searchBtn.Location.X, searchBtn.Location.Y + 30);
            this.Controls.Add(label3);
            label3.BringToFront();
            label4 = new Label();
            label4.Location = new Point(historyBtn.Location.X, historyBtn.Location.Y + 30);
            this.Controls.Add(label4);
            label4.BringToFront();
            label5 = new Label();
            label5.Location = new Point(profileBtn.Location.X, profileBtn.Location.Y + 30);
            this.Controls.Add(label5);
            label5.BringToFront();
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.BackColor = Color.Red;
            label5.Width = 0;
            label5.Height = 5;
            label5.Width = searchBtn.Width;
            label5.BorderStyle = BorderStyle.None;
            label6 = new Label();
            label6.Location = new Point(settingsBtn.Location.X, settingsBtn.Location.Y + 35);
            this.Controls.Add(label6);
            label6.BringToFront();
        }

        void importInformation()
        {
            string imageLocation = Environment.CurrentDirectory + @"\Data\Profiles\Profiles Icons\" + profileIndex + ".png";
            pictureBox1.ImageLocation = imageLocation;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Console.WriteLine(imageLocation);
            nameLabel.Text = userName;
            accountLabel.Text = accountName;
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
        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage f = new MainPage(userName, accountName, profileIndex);
            f.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchBox f = new SearchBox(userName, accountName, profileIndex);
            f.Show();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            History f = new History(userName, accountName, profileIndex);
            f.Show();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountInfo f = new AccountInfo(userName, accountName, profileIndex);
            f.Show();
        }

        private void homeBtn_MouseHover(object sender, EventArgs e)
        {
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.BackColor = Color.Red;
            label2.Width = 0;
            label2.Height = 5;
            while (label2.Width != homeBtn.Width)
                label2.Width += 1;
            label2.BorderStyle = BorderStyle.None;
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                menuItem1.Width = settingsBtn.Width;
                menuItem1.Height = settingsBtn.Height;
                menuItem1.Text = "SignOut";
                menuItem1.BackColor = ColorTranslator.FromHtml("#202020");
                label6.Width = settingsBtn.Width;
                label6.BackColor = ColorTranslator.FromHtml("#0066B4");
                isCollapsed = true;
            }
            else
            {
                menuItem1.Width = 0;
                menuItem1.Height = 0;
                menuItem1.Text = "";
                menuItem1.BackColor = Color.Transparent;
                label6.Width = 0;
                label6.BackColor = Color.Transparent;
                isCollapsed = false;
            }
        }

        private void settingsBtn_MouseLeave(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                label6.Width = 0;
                label6.Height = 5;
                label6.BackColor = Color.Transparent;
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void settingsBtn_MouseHover(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                label6.BorderStyle = BorderStyle.Fixed3D;
                label6.BackColor = ColorTranslator.FromHtml("#0066B4");
                label6.Width = 0;
                label6.Height = 5;
                while (label6.Width != settingsBtn.Width)
                    label6.Width += 1;
                label6.BorderStyle = BorderStyle.None;
            }
        }


        private void homeBtn_MouseLeave(object sender, EventArgs e)
        {
            label2.Width = 0;
            label2.Height = 5;
            label2.BackColor = Color.Transparent;
        }


        private void searchBtn_MouseHover(object sender, EventArgs e)
        {
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.BackColor = Color.Red;
            label3.Width = 0;
            label3.Height = 5;
            while (label3.Width != searchBtn.Width)
                label3.Width += 1;
            label3.BorderStyle = BorderStyle.None;
        }

        private void searchBtn_MouseLeave(object sender, EventArgs e)
        {
            label3.Width = 0;
            label3.Height = 5;
            label3.BackColor = Color.Transparent;
        }

        private void historyBtn_MouseHover(object sender, EventArgs e)
        {
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.BackColor = Color.Red;
            label4.Width = 0;
            label4.Height = 5;
            while (label4.Width != searchBtn.Width)
                label4.Width += 1;
            label4.BorderStyle = BorderStyle.None;
        }

        private void historyBtn_MouseLeave(object sender, EventArgs e)
        {
            label4.Width = 0;
            label4.Height = 5;
            label4.BackColor = Color.Transparent;
        }

    }
}
