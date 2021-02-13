using System.IO;
using System;

namespace Netflix
{
    // A class Which Handles Everything Related To File Handling
    // Features
    /// <summary>
    /// * Single File Handling
    /// * Multi File Handling
    /// * Bugs & Exception Removal Helping Functions
    /// </summary>
    class FileHandlingUtilites
    {
        private int numberOfFiles;
        public int numberOfLines;
        public string content;
        public string[] fileDirectories;
        public FileHandlingUtilites()
        {
            numberOfFiles = 0;
            numberOfLines = 0;
            content = "";
        }
        // For Single File Handling
        // START Utitlities
        public LinkedList importToLinkedList(string fileDirectory)
        {
            LinkedList obj = new LinkedList();
            numberOfLines = 0;
            createFile(fileDirectory);
            FileStream fs = new FileStream(fileDirectory, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = "NULL";
            while (str != null)
            {
                str = sr.ReadLine();
                numberOfLines++;
                obj.Push(str);
            }
            sr.Close();
            fs.Close();
            return obj;
        }


        public Stack importToStack(string fileDirectory)
        {
            Stack obj = new Stack();
            numberOfLines = 0;
            FileStream fs = new FileStream(fileDirectory, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = "NULL";
            while (str != null)
            {
                str = sr.ReadLine();
                numberOfLines++;
                obj.Push(str);
            }
            sr.Close();
            fs.Close();
            return obj;
        }


        public string[] readAllFiles(string fileDirectory)
        {
            Queue queue = new Queue();
            string[] paths = { };
            paths = Directory.GetFiles(fileDirectory);
            foreach (String path in paths)
            {
                string imageName = Path.GetFileName(path);
                string[] fileName = imageName.Split('.');
                queue.enqueue(fileName[0]);
            }
            string[] files = new string[(queue.rear + 1)];
            for (int i = 0; i < (queue.rear + 1); i++)
                files[i] = queue.dequeue();
            return files;
        }
        public int calculateContentSizeOfAFile(string fileDirectory)
        {
            int filesSize = 0;
            FileStream fs = new FileStream(fileDirectory, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                str = sr.ReadLine();
                filesSize++;
            }
            sr.Close();
            fs.Close();
            return filesSize;

        }
        public string[] returnContentsOfAFile(string fileDirectory)
        {
            int size = calculateContentSizeOfAFile(fileDirectory);
            string[] arr = new string[size];
            FileStream fs = new FileStream(fileDirectory, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            int i = 0;
            while (str != null)
            {
                str = sr.ReadLine();
                arr[i] = str;
                i++;
            }
            sr.Close();
            fs.Close();
            return arr;
        }
        public void ReadData(string fileDirectory)
        {
            numberOfLines = 0;
            FileStream fs = new FileStream(fileDirectory, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                str = sr.ReadLine();
                numberOfLines++;
                content = str;
            }
            sr.Close();
            fs.Close();
        }
        public void WriteData(string fileDirectory, string data)
        {
            FileStream fs = new FileStream(fileDirectory, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine((data));
            sw.Flush();
            sw.Close();
            fs.Close();
        }


        // END Utitlities

        // For Multiple File Handling
        // START Utitlities
        private void storeFileDirectoriesFromAFile(string srcFileDirectory, string destFileDirectory)
        {
            ReadData(srcFileDirectory);
            fileDirectories = new string[numberOfLines];
            FileStream fs = new FileStream(srcFileDirectory, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            string defaultFileDirectory = "";
            numberOfFiles = 0;
            defaultFileDirectory = (destFileDirectory + str);
            fileDirectories[numberOfFiles] = defaultFileDirectory;
            //Console.WriteLine("Total Size: " + numberOfLines);
            while (str != null)
            {
                //Console.WriteLine(fileDirectories[numberOfFiles] + ".txt");
                if (numberOfFiles == numberOfLines - 1)
                    break;
                numberOfFiles++;
                str = sr.ReadLine();
                defaultFileDirectory = (destFileDirectory + str);
                fileDirectories[numberOfFiles] = defaultFileDirectory;
            }
            sr.Close();
            fs.Close();
            numberOfLines = 0;
        }
        public int calculateContentSizeOfDirectories(string srcFileDirectory, string destFileDirectory, string extension)
        {
            storeFileDirectoriesFromAFile(srcFileDirectory, destFileDirectory);
            int filesSize = 0;
            for (int i = 0; i <= numberOfFiles; i++)
            {
                FileStream fs = new FileStream((fileDirectories[i] + extension), FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string str = sr.ReadLine();
                while (str != null)
                {
                    str = sr.ReadLine();
                    filesSize++;
                }
                sr.Close();
                fs.Close();
            }
            numberOfLines = filesSize;
            return filesSize;
        }
        public string[] returnContentOfDirectories(string srcFileDirectory, string destFileDirectory, string extension, int sizeOfArr, int numberOfFiles)
        {
            if (numberOfFiles == -1)
                numberOfFiles = calculateContentSizeOfDirectories(srcFileDirectory, destFileDirectory, extension);
            int j = 0;
            string[] arr = new string[sizeOfArr];
            //Console.WriteLine("Size of Arr:" + sizeOfArr);
            //string tempString;
            for (int i = 0; i < numberOfFiles; i++)
            {
                FileStream fs = new FileStream((fileDirectories[i] + extension), FileMode.Open, FileAccess.Read);
                Console.WriteLine(fileDirectories[i]);
                StreamReader sr = new StreamReader(fs);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string str = "null";
                while (str != null)
                {
                    if (j == sizeOfArr)
                    {
                        //Console.WriteLine(str);
                        break;
                    }
                    if ((str[0] >= 65 && str[0] <= 90) || (str[0] >= 97 && str[0] <= 122))
                    {
                        str = sr.ReadLine();
                        if (str != null)
                        {
                            arr[j] = str;
                            //Console.WriteLine(arr[j]);
                            j++;
                        }
                        //Console.WriteLine(arr[j]);
                    }
                    /*                    if (str == tempString)
                                            str = sr.ReadLine();
                    */
                }
                sr.Close();
                fs.Close();
            }
            return arr;
        }

        // END Utitlities

        // For Helpful Functions
        // START Utitlities

        // ? Creates A File If It Doesnt Exist
        public void createFile(string path)
        {
            if (!File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                fs.Close();
            }
        }

        // ? Creates A Directory If It Doesnt Exist
        public void createDirectory(string fileDirectory)
        {
            if (!Directory.Exists(fileDirectory))
                Directory.CreateDirectory(fileDirectory);
        }

        // END Utitlities

    }
}
