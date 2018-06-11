using System;
using System.Collections.Generic;
using System.Text;

namespace LinkLists.Classes
{
    class LinkList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LinkList(Node node)
        {
            Head = node;
            Current = node;
        }
        
        public void AddNode(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }
    }
}
