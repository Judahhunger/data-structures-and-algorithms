using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class LinkLists
    {
        public Node Head { get; set; }

        public Node Current { get; set; }

        public LinkLists(Node node)
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

        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
            }

            Current = Current.Next; 
        }

        /*public void AddAfter(Node newNode, Node existingNode)
        {
            Current = Head;
            while (true)
            {

            }
        }*/

        public void AddLast(Node newNode)
        {
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }

        public Node Find(int value)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return Current.Value == value ? Current : null;
        }
        
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value}--->");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value}---> null");
        }
    }
}
