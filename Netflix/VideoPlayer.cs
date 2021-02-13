using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Netflix
{
    public partial class VideoPlayer : Form
    {
        DoublyLinkedList circularLinkedList;
        string[] arr, fileDirectories;
        string ImageNewName = "", userName, accountName;
        int count = 0, tagIndex = 0, profileIndex;
        string currentMovie;
        bool playBackStatus;
        string imageLocation = @"E:\C++\Netflix\Netflix\Custom UI\Video Player Icons\";
        public VideoPlayer(string userName, string accountName, string movieName, int index)
        {
            InitializeComponent();
            circularLinkedList = new DoublyLinkedList();
            this.userName = userName; this.accountName = accountName;
            this.profileIndex = index;
            currentMovie = movieName;
            playBackStatus = true;
            axMoviePlayer1.SoundVolume = volumeControl.Value;
            initalizeControlBar();
            startMovie();
            Method1();
        }

        void initalizeControlBar()
        {
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

        void startMovie()
        {
            progressBar1.Value = 0;
            timer1.Start();
            titleLabel.Text = currentMovie;
            label1.Width = titleLabel.Width + 70;
            axMoviePlayer1.FileName = @"E:\C++\Netflix\Netflix\Data\Movie Titles\Movie Trailers\" + currentMovie + ".mp4";
            axMoviePlayer1.Play();
            progressBar1.Width = axMoviePlayer1.Width;
            progressBar1.Maximum = (int)axMoviePlayer1.Duration;
        }
        public void Method1()
        {
            FileHandlingUtilites fileHandling = new FileHandlingUtilites();
            string srcFileDirectory = @"E:\C++\Netflix\Netflix\Data\Profiles\" + accountName + @"\" + userName + @"\preferences.txt";
            string destFileDirectory = @"E:\C++\Netflix\Netflix\Data\Movie Titles\", extension = ".txt";
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
                {
                    circularLinkedList.insertEnd(arr[i]);
                    //Console.WriteLine(circularLinkedList.str_name[i]);
                }
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
            string fileDirectory = @"E:\C++\Netflix\Netflix\Data\Profiles\" + accountName + @"\" + userName + @"\Log.txt";
            FileHandlingUtilites f = new FileHandlingUtilites();
            f.WriteData(fileDirectory, selected);
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
                tagIndex = circularLinkedList.str_name.Length - 2;
                currentMovie = listView1.Items[tagIndex].Text;
            }
            while (currentMovie == "" || currentMovie == null)
                currentMovie = listView1.Items[--tagIndex].Text;
            string selected = circularLinkedList.str_name[tagIndex];
            string fileDirectory = @"E:\C++\Netflix\Netflix\Data\Profiles\" + accountName + @"\" + userName + @"\Log.txt";
            FileHandlingUtilites f = new FileHandlingUtilites();
            f.WriteData(fileDirectory, selected);
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
            int reverseValue = (int)axMoviePlayer1.GetPos() - 10;
            if (progressBar1.Value >= 10)
                progressBar1.Value -= 10;
            else return;
            axMoviePlayer1.Pause();
            axMoviePlayer1.StartTime = reverseValue;
            axMoviePlayer1.Play();
        }

        private void volume_Scroll(object sender, EventArgs e)
        {
            axMoviePlayer1.SoundVolume = volumeControl.Value;
            if (axMoviePlayer1.SoundVolume < 0)
                axMoviePlayer1.SoundVolume = 100;
            else if (axMoviePlayer1.SoundVolume > 100)
                axMoviePlayer1.SoundVolume = 0;
            volumePercentage.Text = ((axMoviePlayer1.SoundVolume).ToString() + "%");
        }

        private void fullScreenBtn_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.ShowFullScreen(true);
        }

        private void fastForwardBtn_Click(object sender, EventArgs e)
        {
            int forwardValue = (int)axMoviePlayer1.GetPos() + 10;
            if (progressBar1.Value <= axMoviePlayer1.Duration - 10)
                progressBar1.Value += 10;
            else return;
            axMoviePlayer1.Pause();
            axMoviePlayer1.StartTime = forwardValue;
            axMoviePlayer1.Play();
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
                this.Hide();
                string selected = listView1.SelectedItems[0].Text;
                string fileDirectory = @"E:\C++\Netflix\Netflix\Data\Profiles\" + accountName + @"\" + userName + @"\Log.txt";
                FileHandlingUtilites f = new FileHandlingUtilites();
                f.WriteData(fileDirectory, selected);
                VideoPlayer j = new VideoPlayer(userName, accountName, selected, profileIndex);
                j.Show();
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
                    imageLocation = @"E:\C++\Netflix\Netflix\Data\Movie Titles\Movie Icons\" + circularLinkedList.str_name[i] + ".png";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == axMoviePlayer1.Duration)
                playOrPause();
            progressBar1.Increment(1);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.Stop();
            this.Hide();
            MainPage f = new MainPage(userName, accountName, profileIndex);
            f.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.Stop();
            this.Hide();
            SearchBox f = new SearchBox(userName, accountName, profileIndex);
            f.Show();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.Stop();
            this.Hide();
            History f = new History(userName, accountName, profileIndex);
            f.Show();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            axMoviePlayer1.Stop();
            this.Hide();
            SearchBox f = new SearchBox(userName, accountName, profileIndex);
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
            axMoviePlayer1.Stop();
            this.Hide();
            MainPage f = new MainPage(userName, accountName, profileIndex);
            f.Show();
        }
    }
}
