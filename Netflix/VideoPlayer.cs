// * One Of The Major Highlights Of This Program
/**
    ** This Program Consists Of:
    ** A Full Fledged Video Player With The Assistance Of SDK From AX Movie Player
    ** Again Using The Recommendation System Here For Recommendations
 */ 
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Netflix
{
    public partial class VideoPlayer : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        bool isCollapsed = false, isMaximized = false;
        Label label5, label6, label7;

        FileHandlingUtilites fileHandling = new FileHandlingUtilites();
        DoublyLinkedList circularLinkedList;
        string[] arr, fileDirectories, likedVideos;
        string ImageNewName = "", userName, accountName;
        int count = 0, tagIndex = 0, profileIndex;
        string currentMovie;
        bool playBackStatus, currentLikeStatus = false;
        string imageLocation = Environment.CurrentDirectory + @"\Custom UI\Video Player Icons\";

        public VideoPlayer(string userName, string accountName, string movieName, int index)
        {
            importAccountInformation(userName, accountName, index);
            initalizeAppComponents();
            initalizeMoviePlayer(movieName);
            Method1();
        }

        public void importAccountInformation(string userName, string accountName, int profileIndex)
        {
            this.userName = userName; this.accountName = accountName;
            this.profileIndex = profileIndex;
        }

        public void initalizeAppComponents()
        {
            InitializeComponent();
            initializeLabels();
            circularLinkedList = new DoublyLinkedList();
            importLikedVideos();
        }

        public void initalizeMoviePlayer(string movieName)
        {
            initializeAXMoviePlayerSettings();
            currentMovie = movieName;
            playBackStatus = true;
            initalizeControlBar();
            startMovie();
        }

        void initializeLabels()
        {
            label5 = new Label();
            label5.Location = new Point(profileBtn.Location.X, profileBtn.Location.Y + 35);
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

        void initalizeControlBar()
        {
            likeBtn.ImageLocation = imageLocation + "heart_unselected.png";
            likeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            playPauseBtn.ImageLocation = imageLocation + "Pause.png";
            playPauseBtn.SizeMode = PictureBoxSizeMode.Zoom;
            fastForwardBtn.ImageLocation = imageLocation + "Forward.png";
            fastForwardBtn.SizeMode = PictureBoxSizeMode.Zoom;
            reverseBtn.ImageLocation = imageLocation + "Reverse.png";
            reverseBtn.SizeMode = PictureBoxSizeMode.Zoom;
            reverseBtn.ImageLocation = imageLocation + "Rewind.png";
            reverseBtn.SizeMode = PictureBoxSizeMode.Zoom;
            previousBtn.ImageLocation = imageLocation + "Start.png";
            previousBtn.SizeMode = PictureBoxSizeMode.Zoom;
            nextBtn.ImageLocation = imageLocation + "End.png";
            nextBtn.SizeMode = PictureBoxSizeMode.Zoom;
            fullScreenBtn.ImageLocation = imageLocation + "Full Screen.png";
            fullScreenBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            fullScreenBtn.BackColor = Color.Transparent;

        }

        void initializeAXMoviePlayerSettings()
        {
            volumeControl.Value = 10000;
            axMoviePlayer1.UseVMR9 = true;
            axMoviePlayer1.RegisterMsg();
            axMoviePlayer1.SetMPEG1AudioChannel(0);
        }

        void importLikedVideos()
        {
            string srcFileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + accountName + @"\" + userName + @"\likedVideos.txt";
            fileHandling.createFile(srcFileDirectory);
            likedVideos = fileHandling.returnContent(srcFileDirectory);
        }


        void startMovie()
        {
            if (isVideoLiked(currentMovie))
                likeON();
            else
                likeOFF();
            progressBar1.Value = 0;
            totalDuration.Text = "0";
            timer1.Start();
            titleLabel.Text = currentMovie;
            label1.Width = titleLabel.Width + 70;
            axMoviePlayer1.FileName = Environment.CurrentDirectory + @"\Data\Movie Titles\Movie Trailers\" + currentMovie + ".mp4";
            axMoviePlayer1.Play();
            progressBar1.Maximum = (int)axMoviePlayer1.Duration;
            TimeSpan time = TimeSpan.FromSeconds(progressBar1.Maximum);
            totalDuration.Text = time.ToString();
        }
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
            addToLinkedList();
        }

        private void addToLinkedList()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != " " || arr[i] != "\n")
                    circularLinkedList.insertEnd(arr[i]);
            }
            circularLinkedList.storeData(arr.Length);
        }

        private void VideoPlayBack_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                if (axMoviePlayer1.SoundVolume <= 100)
                    axMoviePlayer1.SoundVolume += 10;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            tagIndex++;
            if (tagIndex < 0 || tagIndex == circularLinkedList.str_name.Length - 1)
                tagIndex = 0;
            try
            {
                currentMovie = listView1.Items[tagIndex].Text;
            }
            catch
            {
                tagIndex = 1;
                currentMovie = listView1.Items[tagIndex].Text;
            }
            while (currentMovie == "" || currentMovie == null)
                currentMovie = listView1.Items[++tagIndex].Text;
            string selected = circularLinkedList.str_name[tagIndex];
            string fileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + accountName + @"\" + userName + @"\Log.txt";
            fileHandling.WriteData(fileDirectory, selected);
            startMovie();
        }
        private void previousBtn_Click(object sender, EventArgs e)
        {
            tagIndex--;
            if (tagIndex < 0 || tagIndex == circularLinkedList.str_name.Length)
                tagIndex = circularLinkedList.str_name.Length - 1;
            try
            {
                currentMovie = listView1.Items[tagIndex].Text;
            }
            catch
            {
                tagIndex = circularLinkedList.str_name.Length - 5;
                currentMovie = listView1.Items[tagIndex].Text;
            }
            while (currentMovie == "" || currentMovie == null)
                currentMovie = listView1.Items[--tagIndex].Text;
            string selected = circularLinkedList.str_name[tagIndex];
            string fileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + accountName + @"\" + userName + @"\Log.txt";
            fileHandling.WriteData(fileDirectory, selected);
            startMovie();
        }

        private void playPauseBtn_Click(object sender, EventArgs e)
        {
            playOrPause();
        }
        private void playOrPause()
        {
            if (playBackStatus == true)
            {
                axMoviePlayer1.Play();
                timer1.Start();
                playPauseBtn.ImageLocation = imageLocation + "Pause.png";
                playPauseBtn.SizeMode = PictureBoxSizeMode.Zoom;
                playBackStatus = false;
            }
            else if (playBackStatus == false)
            {
                axMoviePlayer1.Pause();
                timer1.Stop();
                playPauseBtn.ImageLocation = imageLocation + "Play.png";
                playPauseBtn.SizeMode = PictureBoxSizeMode.Zoom;
                playBackStatus = true;
            }
        }

        private void reverseBtn_Click(object sender, EventArgs e)
        {
            this.axMoviePlayer1.SetPos((double)(axMoviePlayer1.GetPos() - 10));
            timer1.Interval += 1000;
        }
        private void fastForwardBtn_Click(object sender, EventArgs e)
        {
            this.axMoviePlayer1.SetPos((double)(axMoviePlayer1.GetPos() + 10));
            timer1.Interval += 1000;
        }

        private void volume_Scroll(object sender, EventArgs e)
        {
            axMoviePlayer1.SoundVolume = volumeControl.Value - 3500;
            int realVolume = (axMoviePlayer1.SoundVolume / 100 + 35);
            if (realVolume < 0)
                realVolume *= -1;
            volumePercentage.Text = ((realVolume).ToString() + "%");
        }

        private void fullScreenBtn_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.ShowFullScreen(true);
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
                axMoviePlayer1.Stop();
                currentMovie = listView1.SelectedItems[0].Text;
                string fileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + accountName + @"\" + userName + @"\Log.txt";
                fileHandling.WriteData(fileDirectory, currentMovie);
                startMovie();
            }
        }

        private void populate()
        {
            string imageLocation = "";
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(110, 75);
            string[] paths = { };
            for (int i = 0; i < circularLinkedList.str_name.Length; i++)
            {
                try
                {
                    if (circularLinkedList.str_name[i] == " " || circularLinkedList.str_name[i] == "\n")
                        continue;
                    imageLocation = Environment.CurrentDirectory + @"\Data\Movie Titles\Movie Icons\" + circularLinkedList.str_name[i] + ".png";
                    imgs.Images.Add(Image.FromFile(imageLocation));
                    listView1.Items.Add(new ListViewItem
                    {
                        ImageIndex = count,
                        Text = circularLinkedList.str_name[i],
                        Tag = circularLinkedList.str_name[i],
                    }); ; ; ;
                    count++;
                }
                catch
                {
                    Console.WriteLine(circularLinkedList.str_name[i] + " is not found");
                }
            }
            listView1.LargeImageList = imgs; // Setting Size Of Images
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

        private void VideoPlayBack_Load(object sender, EventArgs e)
        {
            listView1.Alignment = ListViewAlignment.Left;
            populate();
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


        private void menuItem1_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.Stop();
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == (int)(axMoviePlayer1.Duration))
            {
                object s = null;
                EventArgs ef = null;
                nextBtn_Click(s, ef);
            }
            TimeSpan time = TimeSpan.FromSeconds(progressBar1.Value);
            currentDuration.Text = time.ToString();
            progressBar1.Increment(1);
        }


        private void likedVideosBtn_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.Stop();
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


        private void homeBtn_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.Stop();
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.Stop();
            this.Hide();
            SearchBox f = new SearchBox(userName, accountName, profileIndex);
            f.Show();
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
        private void historyBtn_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.Stop();
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
            axMoviePlayer1.Stop();
            this.Hide();
            SearchBox f = new SearchBox(userName, accountName, profileIndex);
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

        private void likeBtn_Click(object sender, EventArgs e)
        {
            if (currentLikeStatus == false)
            {
                likeON();
                string srcFileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + accountName + @"\" + userName + @"\likedVideos.txt";
                fileHandling.WriteData(srcFileDirectory, currentMovie);
            }
            else
            {
                likeOFF();
                string srcFileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + accountName + @"\" + userName + @"\likedVideos.txt";
                File.WriteAllLines(srcFileDirectory, File.ReadAllLines(srcFileDirectory).Skip(1));
            }
        }
        bool isVideoLiked(string currentVideo)
        {
            foreach (string video in likedVideos)
            {
                if (video == currentVideo)
                    return true;
            }
            return false;
        }

        private void likeON()
        {
            currentLikeStatus = true;
            likeBtn.ImageLocation = imageLocation + "heart_selected.png";
            likeBtn.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void likeOFF()
        {
            currentLikeStatus = false;
            likeBtn.ImageLocation = imageLocation + "heart_unselected.png";
            likeBtn.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
                Console.WriteLine(this.Width);
                isMaximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            axMoviePlayer1.Refresh();
            axMoviePlayer1.Width = (this.Width - 150);
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            Close.BackColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackColor = Color.Black;
        }

        private void Maximize_MouseHover(object sender, EventArgs e)
        {
            Maximize.BackColor = Color.DodgerBlue;
        }

        private void Maximize_MouseLeave(object sender, EventArgs e)
        {
            Maximize.BackColor = Color.Black;
        }

        private void Minimize_MouseHover(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.DodgerBlue;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.Stop();
            this.Hide();
            MainPage f = new MainPage(userName, accountName, profileIndex);
            f.Show();
        }
    }
}
