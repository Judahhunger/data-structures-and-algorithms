using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    class LinkLists
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LinkList(Node node)
        {
            Head = node;
            Current = node;
        }

        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = node;
        }
    }
}
