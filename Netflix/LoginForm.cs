using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Netflix
{
    public partial class LoginForm : Form
    {
        LinkedList passwords, accounts;

        FileHandlingUtilites f = new FileHandlingUtilites();
        public LoginForm()
        {
            InitializeComponent();
            importPasswordsAndUsers();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetEntries();
        }
        private void login()
        {
            string ID = userIDBox.Text;
            string pass = passwordBox.Text;
            if (checkIDAndPassword(ID, pass))
            {
                this.Hide();
                ProfilesHandling f = new ProfilesHandling(ID);
                f.Show();
            }
        }
        private void resetEntries()
        {
            userIDBox.Text = "";
            passwordBox.Text = "";
        }
        private void setStatus(int statusNumber, bool setStatus, string message)
        {
            string imageLocation = @"E:\C++\Netflix\Netflix\Custom UI\UI Icons\";
            switch (statusNumber)
            {
                case 0:
                    if (setStatus)
                    {
                        statusID.Text = "";
                        statusSymbolID.ImageLocation = imageLocation + "Right" + ".png";
                    }
                    else
                    {
                        statusID.ForeColor = Color.Red;
                        statusSymbolID.ImageLocation = imageLocation + "Wrong" + ".png";
                        statusID.Text = message;
                    }
                    break;
                case 1:
                    if (setStatus)
                    {
                        statusPassword.Text = "";
                        statusSymbolPassword.ImageLocation = imageLocation + "Right" + ".png";
                    }
                    else
                    {
                        statusPassword.ForeColor = Color.Red;
                        statusSymbolPassword.ImageLocation = imageLocation + "Wrong" + ".png";
                        statusPassword.Text = message;
                    }
                    break;
            }
        }

        private void importPasswordsAndUsers()
        {
            accounts = new LinkedList();
            string accountsDirectory = @"E:\C++\Netflix\Netflix\Data\accounts.txt";
            accounts = f.importToLinkedList(accountsDirectory);
            passwords = new LinkedList();
            string passwordDirectory = @"E:\C++\Netflix\Netflix\Data\passwords.txt";
            passwords = f.importToLinkedList(passwordDirectory);
        }

        public bool checkID(string ID)
        {
            if (accounts.Search(ID))
            {
                setStatus(0, true, "");
                return true;
            }
            setStatus(0, false, "ID Doesn't Match");
            return false;
        }
        private bool checkPassword(string pass)
        {
            if (passwords.Search(pass))
            {
                setStatus(1, true, "");
                return true;
            }
            setStatus(1, false, "Passwords Doesn't Match");
            return false;
        }

        private bool checkIDAndPassword(string ID, string pass)
        {
            if (checkID(ID) && checkPassword(pass))
                return true;
            return false;
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                login();
            if (e.KeyChar == (char)Keys.Escape)
                resetEntries();
        }

        private void resetBtn_MouseHover(object sender, EventArgs e)
        {
            resetBtn.BackColor = Color.RoyalBlue;
        }

        private void resetBtn_MouseLeave(object sender, EventArgs e)
        {
            resetBtn.BackColor = Color.Red;
        }

        private void logInBtn_MouseHover(object sender, EventArgs e)
        {
            logInBtn.BackColor = Color.RoyalBlue;
        }

        private void logInBtn_MouseLeave(object sender, EventArgs e)
        {
            logInBtn.BackColor = Color.Red;
        }
        private void userIDBox_MouseClick(object sender, MouseEventArgs e)
        {
            resetTransition();
            label1.Hide();
            userIDBox.BorderStyle = BorderStyle.Fixed3D;
        }
        private void passwordBox_MouseClick(object sender, MouseEventArgs e)
        {
            resetTransition();
            label2.Hide();
            passwordBox.BorderStyle = BorderStyle.Fixed3D;
        }
        void resetTransition()
        {
            label1.Show();
            label2.Show();
            userIDBox.BorderStyle = BorderStyle.None;
            passwordBox.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartPage f = new StartPage();
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Red;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void LoginForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
