using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//NOTE TO SELF: For the Queue you want to add to the back, and then remove from front.


namespace cis237assignment4
{
    class DroidQueue<Droid>
    {        
        protected class Node
        {
            public Droid DroidData { get; set; }
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


        public void QueueDroid(Droid droid)
        {
           
            Node oldTail = _tail;
            
            _tail = new Node();
            
            _tail.DroidData = droid;
            
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


        public void UnQueueDroid()
        {

        }

    }
}
