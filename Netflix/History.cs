using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Netflix
{
    public partial class History : Form
    {
        Label label2, label3, label4, label5;
        string ImageNewName;
        int count = 0, profileIndex;
        Stack stack;
        string userName, accountName;
        public History(string userName, string accountName, int index)
        {
            InitializeComponent();
            stack = new Stack();
            this.userName = userName;
            this.accountName = accountName;
            this.profileIndex = index;
            initializeLabels();
            importLogFile();
        }

        void importLogFile()
        {
            FileHandlingUtilites f = new FileHandlingUtilites();
            string fileDirectory = @"E:\C++\Netflix\Netflix\Data\Profiles\" + accountName + @"\" + userName + @"\Log.txt";
            f.createFile(fileDirectory);
            stack = f.importToStack(fileDirectory);
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            string selected = listView1.SelectedItems[0].Text;
            string fileDirectory = @"E:\C++\Netflix\Netflix\Data\Profiles\" + accountName + @"\" + userName + @"\Log.txt";
            FileHandlingUtilites f = new FileHandlingUtilites();
            f.WriteData(fileDirectory, selected);
            VideoPlayer j = new VideoPlayer(userName, accountName, selected, profileIndex);
            j.Show();
        }

        private void populate()
        {
            string imageLocation = "";
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(150, 100);
            listView1.SmallImageList = imgs; // Setting Size Of Images
            string[] paths = { };
            while (!stack.IsEmpty())
            {
                try
                {
                    if (stack.Peek() == " " || stack.Peek() == "\n")
                        continue;
                    imageLocation = @"E:\C++\Netflix\Netflix\Data\Movie Titles\Movie Icons\" + stack.Peek() + ".png";
                    imgs.Images.Add(Image.FromFile(imageLocation));
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = count;
                    item.SubItems.Add(stack.Peek());
                    item.Text = stack.Peek();
                    listView1.Items.Add(item);
                    count++;
                    stack.Pop();
                }
                catch
                {
                    Console.WriteLine(stack.Peek() + " is not found");
                    stack.Pop();
                }
            }
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

        private void History_Load(object sender, EventArgs e)
        {
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.BackColor = Color.Red;
            label4.Width = 0;
            label4.Height = 5;
            while (label4.Width != searchBtn.Width)
                label4.Width += 1;
            label4.BorderStyle = BorderStyle.None;
            listView1.View = View.Details;
            listView1.Columns.Add("Thumb Nails", 150);
            listView1.Columns.Add("Titles", 300);
            populate();
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
