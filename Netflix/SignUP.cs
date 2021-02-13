using System;
using System.Windows.Forms;
using System.Drawing;

namespace Netflix
{
    public partial class SignUP : Form
    {
        LinkedList linkedList = new LinkedList();
        public SignUP()
        {
            InitializeComponent();
            importAccounts();
        }
        void importAccounts()
        {
            string accountLocation = @"E:\C++\Netflix\Netflix\Data\accounts.txt";
            FileHandlingUtilites f = new FileHandlingUtilites();
            linkedList = f.importToLinkedList(accountLocation);
        }
        private void resetEntries()
        {
            userIDBox.Text = "";
            passwordBox.Text = "";
            confirmPasswordBox.Text = "";
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetEntries();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="statusNumber"></param>
        /// StatusNumber ===  User ID
        /// <param name="setStatus"></param>
        /// setStatus ===  true||wrong
        /// <param name="message"></param>
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
                case 2:
                    if (setStatus)
                    {
                        statusConfirmPassword.Text = "";
                        statusSymbolConfirmPassword.ImageLocation = imageLocation + "Right" + ".png";
                    }
                    else
                    {
                        statusConfirmPassword.ForeColor = Color.Red;
                        statusSymbolConfirmPassword.ImageLocation = imageLocation + "Wrong" + ".png";
                        statusConfirmPassword.Text = message;
                    }
                    break;
            }
        }
        private bool checkUserID(string ID)
        {
            int countNumberOfCharacters = 0, countNumberOfIntegers = 0;
            if (linkedList.Search(ID))
            {
                setStatus(0, false, "Account Already Present!");
                return false; ;
            }
            for (int i = 0; i < ID.Length; i++)
            {
                if (ID[i] == ' ')
                {
                    setStatus(0, false, "Space Detected!");
                    return false;
                }
                if ((ID[i] >= 65 && ID[i] <= 90) || (ID[i] >= 97 && ID[i] <= 122))
                    countNumberOfCharacters++;
                if ((ID[i] >= 48 && ID[i] <= 57))
                    countNumberOfIntegers++;
            }
            if (ID.Length <= 6)
            {
                setStatus(0, false, "Length Too Small!");
                return false;
            }
            if (countNumberOfCharacters <= 3)
            {
                setStatus(0, false, "Low Number Of Characters");
                return false;
            }
            if (countNumberOfIntegers <= 2)
            {
                setStatus(0, false, "Low Number Of Integers");
                return false;
            }
            return true;
        }
        private bool checkPassword(string pass)
        {
            bool checkCapitalLetters, checkSmallLetters, checkSpecialSymbol, checkNumberOfIntegers;
            checkCapitalLetters = checkSmallLetters = checkSpecialSymbol = checkNumberOfIntegers = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] == ' ')
                {
                    setStatus(1, false, "Space Detected!");
                    return false;
                }
                if (pass[i] >= 65 && pass[i] <= 90)
                    checkCapitalLetters = true;
                if (pass[i] >= 97 && pass[i] <= 122)
                    checkSmallLetters = true;
                if ((pass[i] >= 33 && pass[i] <= 47) || (pass[i] >= 58 && pass[i] <= 64))
                    checkSpecialSymbol = true;
                if ((pass[i] >= 48 && pass[i] <= 57))
                    checkNumberOfIntegers = true;
            }
            if (pass.Length <= 6)
            {
                setStatus(1, false, "Length Too Small!");
                return false;
            }
            if (!checkCapitalLetters)
            {
                setStatus(1, false, "No Capital Character!");
                return false;
            }
            if (!checkSmallLetters)
            {
                setStatus(1, false, "No Small Letters!");
                return false;
            }
            if (!checkSpecialSymbol)
            {
                setStatus(1, false, "No Special Symbols!");
                return false;
            }
            if (!checkNumberOfIntegers)
            {
                setStatus(1, false, "No Integers!");
                return false;
            }
            return true;
        }

        private void signUp()
        {
            string ID = userIDBox.Text;
            string pass = passwordBox.Text;
            string confirmPass = confirmPasswordBox.Text;
            if (checkUserID(ID))
                setStatus(0, true, "");
            else
                return;
            if (checkPassword(pass))
                setStatus(1, true, "");
            else
                return;
            if (pass == confirmPass)
            {
                setStatus(2, true, "");
                string fileDirectory = @"E:\C++\Netflix\Netflix\Data\accounts.txt";
                storeData(fileDirectory, ID);
                fileDirectory = @"E:\C++\Netflix\Netflix\Data\passwords.txt";
                storeData(fileDirectory, pass);
                this.Hide();
                LoginForm f = new LoginForm();
                f.Show();
            }
            else
                setStatus(2, false, "Password Doesnt Match!");
        }
        private void storeData(string fileDirectory, string content)
        {
            FileHandlingUtilites f = new FileHandlingUtilites();
            f.WriteData(fileDirectory, content);
        }
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            signUp();
        }
        private void resetBtn_MouseHover(object sender, EventArgs e)
        {
            resetBtn.BackColor = Color.RoyalBlue;
        }

        private void resetBtn_MouseLeave(object sender, EventArgs e)
        {
            resetBtn.BackColor = Color.Red;
        }

        private void signUpBtn_MouseHover(object sender, EventArgs e)
        {
            signUpBtn.BackColor = Color.RoyalBlue;
        }

        private void signUpBtn_MouseLeave(object sender, EventArgs e)
        {
            signUpBtn.BackColor = Color.Red;
        }

        private void confirmPasswordBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                signUp();
            if (e.KeyChar == (char)Keys.Escape)
                resetEntries();
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
        private void confirmPasswordBox_MouseClick(object sender, MouseEventArgs e)
        {
            resetTransition();
            label3.Hide();
            confirmPasswordBox.BorderStyle = BorderStyle.Fixed3D;
        }
        void resetTransition()
        {
            label1.Show();
            label2.Show();
            label3.Show();
            userIDBox.BorderStyle = BorderStyle.None;
            passwordBox.BorderStyle = BorderStyle.None;
            confirmPasswordBox.BorderStyle = BorderStyle.None;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartPage f = new StartPage();
            f.Show();
        }
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
    }
}
