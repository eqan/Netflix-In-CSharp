// * Handles The Profiles Of An Account
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Netflix
{
    public partial class ProfilesHandling : Form
    {
        // ? Handles External User Interactions
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        static private int userCount = 0;
        private string currentAccount = "";
        private string[] profiles;
        private string[] passwords;
        const int size = 5;

        // ? Handles External User Interactions
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public ProfilesHandling(string accountName)
        {
            InitializeComponent();
            currentAccount = accountName;
            profiles = new string[size];
            passwords = new string[size];
            storeProfiles();
        }
        private void storeProfiles()
        {
            FileHandlingUtilites f = new FileHandlingUtilites();
            userCount = 0;
            string fileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + currentAccount + @"\";
            f.createDirectory(fileDirectory);

            string accountsDirectory = fileDirectory + currentAccount + "Profiles.txt";
            f.createFile(accountsDirectory);
            FileStream accountsFile = new FileStream(accountsDirectory, FileMode.Open, FileAccess.Read);
            StreamReader accountStream = new StreamReader(accountsFile);

            string passwordDirectory = fileDirectory + currentAccount + "Passwords.txt";
            f.createFile(passwordDirectory);
            FileStream passwordFile = new FileStream(passwordDirectory, FileMode.Open, FileAccess.Read);
            StreamReader passwordStream = new StreamReader(passwordFile);

            accountStream.BaseStream.Seek(0, SeekOrigin.Begin);
            passwordStream.BaseStream.Seek(0, SeekOrigin.Begin);
            string passwordStr = "", accountStr = "";
            while ((accountStr != null || passwordStr != null))
            {
                accountStr = accountStream.ReadLine();
                passwordStr = passwordStream.ReadLine();
                if (userCount == size || accountStr == "" || passwordStr == "")
                {
                    accountStream.Close();
                    passwordStream.Close();
                    accountsFile.Close();
                    passwordFile.Close();
                    break;
                }
                if (accountStr != null && passwordStr != null)
                {
                    if (accountStr != "\n" || accountStr != "" || passwordStr != "\n" || passwordStr != "")
                    {
                        string imageLocation = Environment.CurrentDirectory + @"\Data\Profiles\Profiles Icons\" + (userCount).ToString() + ".png";
                        Console.WriteLine(userCount + "\n");
                        profiles[userCount] = accountStr;
                        passwords[userCount] = passwordStr;
                        switch (userCount)
                        {
                            case 0:
                                ID1.ImageLocation = imageLocation;
                                ID1.SizeMode = PictureBoxSizeMode.Zoom;
                                label1.Text = accountStr;
                                break;
                            case 1:
                                ID2.ImageLocation = imageLocation;
                                ID2.SizeMode = PictureBoxSizeMode.Zoom;
                                label2.Text = accountStr;
                                break;
                            case 2:
                                ID3.ImageLocation = imageLocation;
                                ID3.SizeMode = PictureBoxSizeMode.Zoom;
                                label3.Text = accountStr;
                                break;
                            case 3:
                                ID4.ImageLocation = imageLocation;
                                ID4.SizeMode = PictureBoxSizeMode.Zoom;
                                label4.Text = accountStr;
                                break;
                            case 4:
                                ID5.ImageLocation = imageLocation;
                                ID5.SizeMode = PictureBoxSizeMode.Zoom;
                                label5.Text = accountStr;
                                break;
                        }
                        userCount++;
                    }
                }
            }
            accountStream.Close();
            passwordStream.Close();
            accountsFile.Close();
            passwordFile.Close();
        }
        private void addUserAndPassword()
        {
            FileHandlingUtilites f = new FileHandlingUtilites();
            string fileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + currentAccount + "/";
            f.WriteData((fileDirectory + currentAccount + "Profiles.txt"), inputBox(false));
            f.WriteData((fileDirectory + currentAccount + "Passwords.txt"), inputBox(true));
            storeProfiles();
        }
        private string inputBox(bool choice) // ? Choice to select password or user name input
        {
            string input = "";
            ShowInputDialog(ref input, choice);
            if (choice)
                passwords[userCount] = input;
            else
                profiles[userCount] = input;
            return input;
        }
        private static DialogResult ShowInputDialog(ref string input, bool choice)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            if (choice)
                inputBox.Text = "Password";
            else
                inputBox.Text = "Name";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            if (choice)
                textBox.UseSystemPasswordChar = true;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (userCount == size)
                MessageBox.Show("Profile Limit Has Reached!");
            else
                addUserAndPassword();
        }


        private void ID1_Click(object sender, EventArgs e)
        {
            checkForNextPage(0);
        }

        private void ID2_Click(object sender, EventArgs e)
        {
            checkForNextPage(1);
        }

        private void ID3_Click(object sender, EventArgs e)
        {
            checkForNextPage(2);
        }

        private void ID4_Click(object sender, EventArgs e)
        {
            checkForNextPage(3);
        }

        private void ID5_Click(object sender, EventArgs e)
        {
            checkForNextPage(4);
        }

        private void checkForNextPage(int index)
        {
            string pass = "";
            ShowInputDialog(ref pass, true);
            if (pass == passwords[index])
            {
                this.Hide();
                UserPreferences f = new UserPreferences(profiles[index], currentAccount, index);
                f.checkIfPreferencesPresent();
            }
            else
                MessageBox.Show("Incorrect Password!");
        }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
        }

    }
}
