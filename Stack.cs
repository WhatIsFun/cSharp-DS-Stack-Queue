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
            if (IsFull())
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
            if (IsEmpty())
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
            if (IsEmpty())
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
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                Console.WriteLine("Stack: ");
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + S[i]);
                }
            }
        }
        private bool IsFull()
        {
            return top == max - 1; 
        }

        private bool IsEmpty()
        {
            return top == -1;
        }
       

        
    }
}
