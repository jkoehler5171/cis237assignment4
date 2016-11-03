using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NOTE TO SELF: For Stack you want to add to the front , and remove from the front.


namespace cis237assignment4
{
    class DroidStack<T>
    {
        protected class Node
        {
            public T DroidData { get; set; }
            public Node Next { get; set; }
        }

        private Node _head;
        private Node _tail;
        private int _size;

        public bool IsEmpty
        {
            get
            {
                return (_head == null);
            }
        }

        public int Size
        {
            get { return _size; }
        }

        public void AddDroid(T data)
        {
            Node oldHead = _head;

            _head = new Node();

            _head.DroidData = data;

            _head.Next = oldHead;

            _size++;

            if (_size == 1)
            {
                _tail = _head;
            }

        }

        public T RemoveDroid()
        {
            if (IsEmpty)
            {
                throw new Exception("No Droids In List!");
            }

            T returnData = _head.DroidData;
            
            _head = _head.Next;
            
            _size--;
            
            if (IsEmpty)
            {
                _tail = null;
            }
            
            return returnData;
        }
    }
}
