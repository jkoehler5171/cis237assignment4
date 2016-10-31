using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
