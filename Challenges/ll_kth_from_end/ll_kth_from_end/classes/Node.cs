using System;
using System.Collections.Generic;
using System.Text;

namespace ll_kth_from_end.classes
{
    public class Node
    {

        public string ThisSays { get; set; }

        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            
        }
    }
}
