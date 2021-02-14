/**
    ** An Algorithm Used For Searching Capabilites Taking Minimal Time To Scrap Through And Search
    ** The Content
 */
using System;
namespace Netflix
{
    public class Hashing
    {
        string[] name;
        int[] visited;
        public int size;
        int count = 0; int index = 0;
        public string[] finalstring;
        public Hashing(string path)
        {
            FileHandlingUtilites f = new FileHandlingUtilites();
            name = f.readAllFiles(path);
            finalstring = new string[name.Length];
            size = name.Length;
            visited = new int[size];
        }


        public void searching(string key)
        {
            int ASCIIVal = 0;
            if (key[0] >= 65 && key[0] <= 90)
                ASCIIVal = 65;
            else if (key[0] >= 97 && key[0] <= 122)
                ASCIIVal = 97;
            else return;
            for (int i = 0; i < size; i++)
            {
                int sum = 0;
                for (int k = 0; k < 2; k++)
                    sum = (key[0] - ASCIIVal);
                int hv = sum % size;
                if (name[hv][0] == char.ToLower(key[0]) && visited[hv] == 0 || name[hv][0] == char.ToUpper(key[0]) && visited[hv] == 0)
                {
                    visited[hv] = 1;
                    int z;
                    if (name[hv].Length < key.Length)
                        z = name[hv].Length;
                    else
                        z = key.Length;
                    for (int m = 0; m < z; m++)
                    {
                        if (name[hv][m] == char.ToLower(key[m]) || name[hv][m] == char.ToUpper(key[m])
)
                        {
                            count++;
                        }
                    }
                    if (count == z)
                    {

                        finalstring[index] = name[hv];
                        count = 0;
                    }
                    count = 0;
                }

                else
                {
                    int count1 = 0;
                    count = 0;
                    for (int j = 0; j < size; j++)
                    {
                        int t = (hv + count1) % size;
                        if (name[t][0] == Char.ToUpper(key[0]) && visited[t] == 0 || name[t][0] == char.ToLower(key[0]) && visited[t] == 0)
                        {
                            visited[t] = 1;
                            int x;
                            if (name[t].Length < key.Length)
                                x = name[t].Length;
                            else
                                x = key.Length;
                            for (int m = 0; m < x; m++)
                                if (name[t][m] == char.ToUpper(key[m]) || name[t][m] == char.ToLower(key[m]))
                                    count++;
                            if (count == x)
                            {
                                finalstring[index] = name[t];
                                index++;
                            }
                            count = 0;
                        }
                        count1++;
                    }
                }
            }
            for (int i = 0; i < size; i++)
                visited[i] = 0;
        }
    }
}