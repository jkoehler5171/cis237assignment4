using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NOTE TO SELF: For Stack you want to add to the front , and remove from the front.


namespace cis237assignment4
{
    class DroidStack<Droid>
    {
        protected class Node
        {
            public Droid DroidData { get; set; }
            public Node Next { get; set; }
        }

        private Node _head;
        private Node _tail;
        private int _size;

        public void AddDroid(Droid droid)
        {
            Node oldHead = _head;

            _head = new Node();

            _head.DroidData = droid;

            _head.Next = oldHead;

            _size++;

            if (_size == 1)
            {
                _tail = _head;
            }

        }
    }
}
