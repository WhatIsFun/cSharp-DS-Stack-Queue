using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_DSStackQueue
{
    internal class Queue
    {
        private int[] Q;
        private int rear;
        private int front;
        //private int max;
        public int size;
        public Queue(int size) 
        {
            Q = new int[size];
            this.size = size;
            rear = 0;
            front = 0;
        }
        public void QueueAdd(int n)
        {
            if (IsFull())
            {
                Console.WriteLine("The Queue is full !!");
                return;
            }
            Q[rear] = n;
            rear++;
            return;
        }
        public void QueueRemove()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            else
            {
                Console.WriteLine("Dequeue element is: " + Q[front]);
                for (int i = 0; i < rear - 1; i++)
                {
                    Q[i] = Q[i + 1];
                }
                if (rear < size)
                    Q[rear] = 0;
                rear--;
            }
            return;
        }
        public void QueuePeek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty");
                return;
            }
            else
            {
                Console.WriteLine("The front element is: " + Q[front]);
            }
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The Queue is Empty");
                return;
            }
            Console.WriteLine("Queue :");
            for (int i = front; i < rear; i++)
            {
                Console.WriteLine("Item[" + (i + 1) + "]: " + Q[i]);
            }
            return;
        }
        private bool IsEmpty()
        {
            return rear == front;
        }
        private bool IsFull()
        {
            return rear == size;
        }
    }
}
