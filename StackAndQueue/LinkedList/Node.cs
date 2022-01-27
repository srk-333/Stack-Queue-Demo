using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.LinkedList
{
    public class Node
    {
        // variables
        public int data;
        public Node next;
        /// <summary>
        /// constructor is used to initialized the data.
        /// </summary>
        /// <param name="data"></param>
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
