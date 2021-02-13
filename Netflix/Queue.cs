using System;

namespace Netflix
{
    class Queue
    {
        public string[] fileNames;
        public int front;
        public int rear;
        private int max = 100000;

        public Queue()
        {
            fileNames = new string[max];
            front = 0;
            rear = -1;
        }
        public void enqueue(string fileName)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                rear++;
                fileNames[rear] = fileName;
                Console.WriteLine("File Names {0} Enqueud!", rear);
            }
        }

        public string dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return "";
            }
            string fileName = fileNames[front];
            Console.WriteLine("File Names {0} Dequed!", front);
            front++;
            return fileName;
        }

        // Function to print queue. 
        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine("File Name {0} Enqueud!", i);
                }
            }
        }
    }
}
