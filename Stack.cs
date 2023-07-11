using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace cSharp_DSStackQueue
{
    internal class Stack
    {
        private int[] S;
        private int top;
        private int max;
        public Stack(int size)
        {
            S = new int[size];
            top = -1;
            max = size;
        }

        public void StackAdd(int n)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack is Full");
                return;
            }
            else
            {
                S[++top] = n;
            }
        }

        public int StackRemove()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element is: " + S[top]);
                return S[top--];
            }
        }

        public void StackPeek()
        {
            if (top == -1)
            {
                Console.WriteLine("The stack is empty");
            }
            else
            {
                Console.WriteLine("The top element is: " + S[top]);
            }

        }
        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + S[i]);
                }
            }
        }

        
    }
}
