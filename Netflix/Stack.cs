using System;

namespace Netflix
{
    class Stack
    {
        // ? As Pointers Can't Be Used Freely in C# Thats Why Using The Array Based Implementation
        int MAX = 1000000;
        public int top;
        string[] stack;
        public bool IsEmpty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top = -1;
            stack = new string[MAX];
        }
        internal bool Push(string data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                Console.WriteLine("{0} has been Pushed!", stack[top]);
                return true;
            }
        }

        internal void Pop()
        {
            if (top < 0)
                Console.WriteLine("Stack Underflow");
            else
            //Console.WriteLine("{0} has been popped!", stack[top--]);
            {
                Console.WriteLine("{0} has been popped!", stack[top--]);
            }
        }

        internal string Peek()
        {
            if (top < 0)
                Console.WriteLine("Stack Underflow");
            else
            {
                //Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
                return stack[top];
            }
            return "";
        }

        internal void PrintStack()
        {
            if (top < 0)
                Console.WriteLine("Stack Underflow");
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                    Console.WriteLine(stack[i]);
            }
            return;
        }
    }
}
