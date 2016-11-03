using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//NOTE TO SELF: For the Queue you want to add to the back, and then remove from front.


namespace cis237assignment4
{
    class DroidQueue<T>
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


        public void QueueDroid(T data)
        {
           
            Node oldTail = _tail;
            
            _tail = new Node();
            
            _tail.DroidData = data;
            
            _tail.Next = null;
                    
            if (IsEmpty)
            {
                _head = _tail;
            }
           
            else
            {
                oldTail.Next = _tail;
            }
           
            _size++;

        }


        public T UnQueueDroid()
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
