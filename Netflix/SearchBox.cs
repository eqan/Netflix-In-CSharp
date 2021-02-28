using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Netflix
{
    public partial class SearchBox : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        Label label2, label3, label4, label5, label6, label7;
        bool isCollapsed = false;
        Hashing obj;
        string[] str;
        string ImageNewName = "", userName, accountName;
        int count = 0, profileIndex;
        public SearchBox(string userName, string accountName, int index)
        {
            InitializeComponent();
            initializeLabels();
            string path = Environment.CurrentDirectory + @"\Data\Movie Titles\Movie Icons\";
            obj = new Hashing(path);
            str = new string[obj.size];
            this.userName = userName; this.accountName = accountName;
            this.profileIndex = index;
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string selected = listView1.SelectedItems[0].Text;
            string fileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + accountName + @"\" + userName + @"\Log.txt";
            FileHandlingUtilites f = new FileHandlingUtilites();
            f.WriteData(fileDirectory, selected);
            this.Hide();
            VideoPlayer j = new VideoPlayer(userName, accountName, selected, profileIndex);
            j.Show();

        }

        private void populate()
        {
            int i = 0;
            string imageLocation = Environment.CurrentDirectory + @"\Data\Movie Titles\Movie Icons\";
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(150, 100);
            listView1.SmallImageList = imgs; // Setting Size Of Images
            string[] paths = { };
            paths = Directory.GetFiles(imageLocation);
            try
            {
                foreach (String path in paths)
                {
                    for (int l = 0; l < obj.size; l++)
                    {
                        if (path == imageLocation + obj.finalstring[l] + ".png")
                        {
                            imgs.Images.Add(Image.FromFile(path));
                            str[i++] = obj.finalstring[l];
                            obj.finalstring[l] = "NULL";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Image Not Found!");
            }

            for (int j = 0; j < imgs.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                item.SubItems.Add(str[j]);
                item.Text = str[j];
                listView1.Items.Add(item);

            }
        }

        private void fill(string searchTerm)
        {
            listView1.Items.Clear();
            obj.searching(searchTerm);
            populate();
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

        private void SearchBox_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ThumbNails", 150);
            listView1.Columns.Add("Titles", 300);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                fill(textBox1.Text);
                resetTransition();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                listView1.Items.Clear();
                textBox1.Text = "";
            }
        }
        void initializeLabels()
        {
            label3 = new Label();
            label3.Location = new Point(searchBtn.Location.X, searchBtn.Location.Y + 30);
            this.Controls.Add(label3);
            label3.BringToFront();
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.BackColor = Color.Red;
            label3.Width = 0;
            label3.Height = 5;
            while (label3.Width != searchBtn.Width)
                label3.Width += 1;
            label3.BorderStyle = BorderStyle.None;
            label2 = new Label();
            label2.Location = new Point(homeBtn.Location.X, homeBtn.Location.Y + 35);
            this.Controls.Add(label2);
            label2.BringToFront();
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
            label7 = new Label();
            label7.Location = new Point(likedVideosBtn.Location.X, likedVideosBtn.Location.Y + 35);
            this.Controls.Add(label7);
            label7.BringToFront();
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
            IntroPage f = new IntroPage();
            f.Show();
        }



        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchBox f = new SearchBox(userName, accountName, profileIndex);
            f.Show();
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

        private void likedVideosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LikedVideos f = new LikedVideos(userName, accountName, profileIndex);
            f.Show();
        }

        private void likedVideosBtn_MouseHover(object sender, EventArgs e)
        {
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.BackColor = Color.Red;
            label7.Width = 0;
            label7.Height = 5;
            while (label7.Width != homeBtn.Width)
                label7.Width += 1;
            label7.BorderStyle = BorderStyle.None;
        }

        private void likedVideosBtn_MouseLeave(object sender, EventArgs e)
        {
            label7.Width = 0;
            label7.Height = 5;
            label7.BackColor = Color.Transparent;
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

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            resetTransition();
            label1.Hide();
            textBox1.BorderStyle = BorderStyle.Fixed3D;
            textBox1.Text = "";
        }
        void resetTransition()
        {
            label1.Show();
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Text = " Search";
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage f = new MainPage(userName, accountName, profileIndex);
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


        private void historyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            History f = new History(userName, accountName, profileIndex);
            f.Show();
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
        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountInfo f = new AccountInfo(userName, accountName, profileIndex);
            f.Show();
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
