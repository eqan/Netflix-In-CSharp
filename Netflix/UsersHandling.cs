using System;
using System.Windows.Forms;
using System.IO;

namespace Netflix
{
    public partial class User1 : Form
    {
        static private int userCount = 0;
        private string currentAccount = "";
        private string[] profiles;
        private string[] passwords;
        const int size = 5;
        public User1(string accountName) // ? Account Name is the Parent Account
        {
            InitializeComponent();
            currentAccount = accountName;
            profiles = new string[size];
            passwords = new string[size];
            storeProfiles();
        }
        private void storeProfiles()
        {
            userCount = 0;
            string fileDirectory = @"E:\C++\Netflix\Netflix\Data\Profiles\";
            string accountsDirectory = fileDirectory + currentAccount + "Profiles.txt";
            makeAFileIfNotExist(accountsDirectory);
            FileStream accountsFile = new FileStream(accountsDirectory, FileMode.Open, FileAccess.Read);
            StreamReader accountStream = new StreamReader(accountsFile);

            string passwordDirectory = fileDirectory + currentAccount + "Passwords.txt";
            makeAFileIfNotExist(passwordDirectory);
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
                string imageLocation = fileDirectory + @"Profiles Icons\" + (userCount + 1).ToString() + ".png";
                //MessageBox.Show(imageLocation);
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
                //MessageBox.Show(accountStr + " " + passwordStr);
                userCount++;
            }
            accountStream.Close();
            passwordStream.Close();
            accountsFile.Close();
            passwordFile.Close();
        }
        private void makeAFileIfNotExist(string path)
        {
            if (!File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                fs.Close();
            } 
        }
        private void addUserAndPassword()
        {
            fileWriter w = new fileWriter();
            string fileDirectory = @"E:\C++\Netflix\Netflix\Data\Profiles\";
            w.WriteData((fileDirectory + currentAccount + "Profiles.txt"), inputBox(false));
            w.WriteData((fileDirectory + currentAccount + "Passwords.txt"), inputBox(true));
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

        private void UsersHandling_Load(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (userCount == size)
                MessageBox.Show("Profile Limit Has Reached!");
            else
                addUserAndPassword();
        }

        private void ID1_Click(object sender, EventArgs e)
        {
            MainPage f = new MainPage(label1.Text);
            MessageBox.Show(label1.Text);
        }
        private void ID2_Click(object sender, EventArgs e)
        {
            MainPage f = new MainPage(label2.Text);
            MessageBox.Show(label2.Text);
        }
        private void ID3_Click(object sender, EventArgs e)
        {
            MainPage f = new MainPage(label3.Text);
            MessageBox.Show(label3.Text);
        }
        private void ID4_Click(object sender, EventArgs e)
        {
            MainPage f = new MainPage(label4.Text);
            MessageBox.Show(label4.Text);
        }
        private void ID5_Click(object sender, EventArgs e)
        {
            MainPage f = new MainPage(label5.Text);
            MessageBox.Show(label5.Text);
        }

        private void User1_Load(object sender, EventArgs e)
        {

        }
    }
}
