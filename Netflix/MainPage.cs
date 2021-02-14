using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Netflix
{
    public partial class MainPage : Form
    {
        Label label2, label3, label4, label5;
        FileHandlingUtilites fileHandling = new FileHandlingUtilites();
        Stack stack;
        string ImageNewName = "";
        int count = 0, profileIndex = 0, posterIndex = 0;
        string[] arr, fileDirectories, posterArr;
        private string userName = "", accountName = "";
        public MainPage(string userName, string accountName, int index)
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
            initializeLabels();
            this.userName = userName;
            this.accountName = accountName;
            this.profileIndex = index;
            importTypeOfPosters();
            initializePoster();
            for (int i = 0; i < posterArr.Length; i++)
                Console.WriteLine(posterArr[i]);
        }

        private void importTypeOfPosters()
        {
            string srcFileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + accountName + @"\" + userName + @"\preferences.txt";
            posterArr = fileHandling.returnContent(srcFileDirectory);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            initializePoster();
        }

        void initializePoster()
        {
            changePoster();
            importPosterDetails();
            posterIndex++;
        }
        void importPosterDetails()
        {
            string detailsLocation = Environment.CurrentDirectory + @"\Data\Movie Titles\Movie Posters\" + posterArr[posterIndex] + ".txt";
            int lineCount = 0;
            richTextBox1.Text = "";
            FileStream fs = new FileStream(detailsLocation, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                if (str != null)
                {
                    if (str != "" || str != "\n")
                    {
                        if (lineCount == 0)
                            movieLabel.Text = str;
                        else if (lineCount == 1)
                        {
                            string[] splitString = str.Split(' ');
                            AudiencWatchLabel.Text = (splitString[0] + " " + splitString[1]);
                            yearLabel.Text = splitString[2];
                        }
                        else
                        {
                            richTextBox1.Text += str;
                        }
                        lineCount++;
                    }
                }
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        void changePoster()
        {
            if (posterIndex == posterArr.Length)
                posterIndex = 0;
            string imageLocation = Environment.CurrentDirectory + @"\Data\Movie Titles\Movie Posters\" + posterArr[posterIndex] + ".png";
            pictureBox1.ImageLocation = imageLocation;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        /// <summary>
        /// *  Method 1 Contains the following steps
        /// 1. Import Directories Of All Selected Preferences
        /// 2. Copy Content of all Selected directories in an array
        /// 3. Use the Fisher-Yates Algoithm to efficiently sparse/randomize the content
        /// 4. Store the content in stack
        /// 5. Load Images From Files
        /// </summary>
        public void Method1()
        {
            string srcFileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + accountName + @"\" + userName + @"\preferences.txt";
            string destFileDirectory = Environment.CurrentDirectory + @"\Data\Movie Titles\", extension = ".txt";
            int size = fileHandling.calculateContentSizeOfDirectories(srcFileDirectory, destFileDirectory, extension);
            fileDirectories = new string[fileHandling.fileDirectories.Length];
            fileDirectories = fileHandling.fileDirectories;
            arr = fileHandling.returnContentOfDirectories(srcFileDirectory, destFileDirectory, extension, size, fileDirectories.Length);
            Fisher_YatesAlgo randomize = new Fisher_YatesAlgo(arr);
            arr = randomize.arr;
            addToStack();
        }

        private void addToStack()
        {
            stack = new Stack();
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != " " || arr[i] != "\n")
                    stack.Push(arr[i]);
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            Method1();
            initializePoster();
            ImageList imageList1 = new ImageList();
            imageList1.ImageSize = new Size(110, 75);
            string imageLocation = "";
            while (!stack.IsEmpty())
            {
                try
                {
                    if (stack.Peek() == " " || stack.Peek() == "\n")
                        continue;
                    imageLocation = Environment.CurrentDirectory + @"\Data\Movie Titles\Movie Icons\" + stack.Peek() + ".png";
                    imageList1.Images.Add(Image.FromFile(imageLocation));
                    listView1.Items.Add(new ListViewItem
                    {
                        ImageIndex = count,
                        Text = stack.Peek(),
                        Tag = stack.Peek()
                    }); ; ;
                    count++;
                    stack.Pop();
                }
                catch
                {
                    Console.WriteLine(stack.Peek() + " is not found");
                    stack.Pop();
                }
            }
            listView1.Alignment = ListViewAlignment.Left;
            listView1.LargeImageList = imageList1;
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
                return;
            ImageNewName = Convert.ToString(e.Label);
            ListViewItem item1 = listView1.SelectedItems[0];
            FileInfo fileInfo = new FileInfo(item1.Tag.ToString());
            fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + ImageNewName + fileInfo.Extension);
            listView1.Items[count].Text = ImageNewName;
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)
            {
                Console.WriteLine(listView1.SelectedItems.Count);
                return;
            }
            int intselectedindex = listView1.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                this.Hide();
                string selected = listView1.SelectedItems[0].Text;
                string fileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + accountName + @"\" + userName + @"\Log.txt";
                FileHandlingUtilites f = new FileHandlingUtilites();
                f.WriteData(fileDirectory, selected);
                VideoPlayer j = new VideoPlayer(userName, accountName, selected, profileIndex);
                j.Show();
            }
        }

        void initializeLabels()
        {
            label2 = new Label();
            label2.Location = new Point(homeBtn.Location.X, homeBtn.Location.Y + 35);
            this.Controls.Add(label2);
            label2.BringToFront();
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.BackColor = Color.Red;
            label2.Width = 0;
            label2.Height = 5;
            while (label2.Width != homeBtn.Width)
                label2.Width += 1;
            label2.BorderStyle = BorderStyle.None;
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
            label6 = new Label();
            label6.Location = new Point(settingsBtn.Location.X, settingsBtn.Location.Y + 35);
            this.Controls.Add(label6);
            label6.BringToFront();

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

        Label label6;
        bool isCollapsed = false;


        private void settingsBtn_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                menuItem1.Width = settingsBtn.Width;
                menuItem1.Height = settingsBtn.Height;
                menuItem1.Text = "SignOut";
                menuItem1.BackColor = ColorTranslator.FromHtml("#202020");
                label6.Width = settingsBtn.Width;
                label6.Height = 5;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval >= 1000)
            {
                initializePoster();
                timer1.Interval = 100;
            }
            timer1.Interval += 100;
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


        private void searchBtn_MouseHover(object sender, EventArgs e)
        {
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.BackColor = Color.Red;
            label3.Width = 0;
            label3.Height = 5;
            while (label3.Width != homeBtn.Width)
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

        private void profileBtn_MouseHover(object sender, EventArgs e)
        {
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.BackColor = Color.Red;
            label5.Width = 0;
            label5.Height = 5;
            while (label5.Width != searchBtn.Width)
                label5.Width += 1;
            label5.BorderStyle = BorderStyle.None;
        }

        private void profileBtn_MouseLeave(object sender, EventArgs e)
        {
            label5.Width = 0;
            label5.Height = 5;
            label5.BackColor = Color.Transparent;
        }

    }
}
