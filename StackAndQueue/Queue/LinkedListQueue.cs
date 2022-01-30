using System;
using StackAndQueue.LinkedList;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.Queue
{
    public class LinkedListQueue
    {
        //variable
        private Node front;
        /// <summary>
        /// Enqueues the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if (this.front == null)
                this.front = node;
            else
            {
                Node rear = this.front;
                while (rear.next != null)
                {
                    rear = rear.next;
                }
                rear.next = node;             
            }
            Console.WriteLine("{0} Enqueued into Queue", value);
        }
        /// <summary>
        /// display the elements of Queue.
        /// </summary>
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = this.front;
                while (temp != null)
                {
                    Console.WriteLine("Element in Queue:"+temp.data);
                    temp = temp.next;
                }
            }
        }
        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Node temp = this.front;
            this.front = front.next;
            temp.next = null;
            Console.WriteLine("{0} Dequeued from Queue",temp.data);
        }
        /// <summary>
        /// Copies the into stack.
        /// </summary>
        public void CopyIntoStack()
        {
            int[] array = new int[6];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(30);
            queue.Enqueue(50);
            queue.Enqueue(78);           
            queue.CopyTo(array, 0);
            foreach (int item in array)
            {
                Console.WriteLine("Element in Array:{0}", item);
            }
            Stack<int> stack = new Stack<int>();
            Console.WriteLine("copy array element into stack");
            foreach (int element in array)
            {
                if (element != 0)
                    stack.Push(element);
            }
            foreach (int element in stack)
            {
                if (element != 0)
                    Console.WriteLine("element in stack:{0}", element);
            }
        }
    }
}