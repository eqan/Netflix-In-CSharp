using System;
using System.Windows.Forms;
using System.Drawing;

namespace Netflix
{
    public partial class UserPreferences : Form
    {
        string fileDirectory, currentProfile, currentAccount;
        static int count = 0;
        const int totalOptions = 7, preferenceLimit = 4;
        int profileIndex = 0;
        string[] selectedLabels;
        FileHandlingUtilites f = new FileHandlingUtilites();
        public UserPreferences(string user, string account, int index)
        {
            InitializeComponent();
            this.currentProfile = user;
            this.currentAccount = account;
            this.profileIndex = index;
            fileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + currentAccount + @"\" + currentProfile;
            fileProcesses();
            selectedLabels = new string[totalOptions];
            for (int i = 0; i < totalOptions; i++)
                selectedLabels[i] = "";
        }
        public void fileProcesses()
        {
            f.createDirectory(fileDirectory);
            fileDirectory += @"\preferences.txt";
            f.createFile(fileDirectory);
            f.ReadData(fileDirectory);
        }
        public void checkIfPreferencesPresent()
        {
            if (f.numberOfLines > 0)
            {
                this.Hide();
                MainPage f = new MainPage(currentProfile, currentAccount, profileIndex);
                f.Show();
            }
            else this.Show();
        }
        private void makeLog(string labelName, int i)
        {
            if (count == preferenceLimit)
            {
                if (isLabelStored(labelName, i))
                    return;
                MessageBox.Show("OOPs You Have Reached The Limit!");
                return;
            }
            if (isLabelStored(labelName, i))
                return;
            if (selectedLabels[i] == "")
            {
                setIDImage(i, true);
                selectedLabels[i] = labelName;
                count++;
            }
        }
        // ? Boolean Type Refers to True if Selected & False For Unselected 
        private void setIDImage(int index, bool type)
        {
            string imageLocation = Environment.CurrentDirectory + @"\Data\Movie Titles\Genre Icons\";
            switch (index)
            {
                case 0:
                    if (type == false)
                        ID0.ImageLocation = (imageLocation + "Action.png");
                    else
                        ID0.ImageLocation = (imageLocation + "Selected_Action.png");
                    ID0.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 1:
                    if (type == false)
                        ID1.ImageLocation = (imageLocation + "Children.png");
                    else
                        ID1.ImageLocation = (imageLocation + "Selected_Children.png");
                    ID1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    if (type == false)
                        ID2.ImageLocation = (imageLocation + "Mystery.png");
                    else
                        ID2.ImageLocation = (imageLocation + "Selected_Mystery.png");
                    ID2.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    if (type == false)
                        ID3.ImageLocation = (imageLocation + "Drama.png");
                    else
                        ID3.ImageLocation = (imageLocation + "Selected_Drama.png");
                    ID3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 4:
                    if (type == false)
                        ID4.ImageLocation = (imageLocation + "Comedy.png");
                    else
                        ID4.ImageLocation = (imageLocation + "Selected_Comedy.png");
                    ID4.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 5:
                    if (type == false)
                        ID5.ImageLocation = (imageLocation + "Horror.png");
                    else
                        ID5.ImageLocation = (imageLocation + "Selected_Horror.png");
                    ID5.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 6:
                    if (type == false)
                        ID6.ImageLocation = (imageLocation + "Romance.png");
                    else
                        ID6.ImageLocation = (imageLocation + "Selected_Romance.png");
                    ID6.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }
        private bool isLabelStored(string labelName, int i)
        {
            if (labelName == selectedLabels[i])
            {
                setIDImage(i, false);
                selectedLabels[i] = "";
                count--;
                return true;
            }
            return false;
        }
        private void storeLog()
        {
            for (int i = 0; i < totalOptions; i++)
                if (selectedLabels[i] != "")
                    f.WriteData(fileDirectory, selectedLabels[i]);
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if(count <= 2)
            {
                MessageBox.Show("Please select at least 3 Preferneces!");
                return;
            }
            storeLog();
            this.Hide();
            MainPage f = new MainPage(currentProfile, currentAccount, profileIndex);
            f.Show();
        }
        private void ID0_Click(object sender, EventArgs e)
        {
            makeLog(label0.Text, 0);
        }

        private void ID1_Click(object sender, EventArgs e)
        {
            makeLog(label1.Text, 1);
        }

        private void ID2_Click(object sender, EventArgs e)
        {
            makeLog(label2.Text, 2);
        }

        private void ID3_Click(object sender, EventArgs e)
        {
            makeLog(label3.Text, 3);
        }

        private void ID4_Click(object sender, EventArgs e)
        {
            makeLog(label4.Text, 4);
        }
        private void ID5_Click(object sender, EventArgs e)
        {
            makeLog(label5.Text, 5);
        }

        private void ID6_Click(object sender, EventArgs e)
        {
            makeLog(label6.Text, 6);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfilesHandling f = new ProfilesHandling(currentAccount);
            f.Show();
        }

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
