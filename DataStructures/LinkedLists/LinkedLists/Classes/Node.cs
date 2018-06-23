using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
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
