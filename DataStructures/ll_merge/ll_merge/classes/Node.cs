﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ll_merge.classes
{
    public class Node
    {
       
        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
