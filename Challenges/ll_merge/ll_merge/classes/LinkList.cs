using System;
using System.Collections.Generic;
using System.Text;

namespace ll_merge.classes
{
    public class LinkList
    {
        public Node Runner { get; set; }

        public Node Head { get; set; }

        public Node Current { get; set; }

        public LinkList(Node node)
        {
            Head = node;
            Current = node;
        }
        /// <summary>
        /// find starting node(head) then make new node point to starting node
        /// then make new node the head.
        /// </summary>
        /// <param Node="node"></param>
        public void Add(Node node)//tested //
        {
            node.Next = Head;
            Head = node;
            Current = node;
        }
        /// <summary>
        /// finds node that points to the node before insertion.
        /// new node then points to the node before insertion.
        /// the node before insertion now points to new node.
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="existingNode"></param>
        public void AddBefore(Node newNode, Node existingNode)//tested
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
                Current = Current.Next;
            }


        }

        /// <summary>
        /// Find existing nodes value and make the current
        /// Change new nodes next from null to existing node next.
        /// Change existing nodes next to the new node.
        /// </summary>
        /// <param Node="newNode"></param>
        /// <param Node="existingNode"></param>
        public void AddAfter(Node newNode, Node existingNode)//tested
        {
            Current = Head;
            Current = Find(existingNode.Value);

            newNode.Next = Current.Next;
            existingNode.Next = newNode;
        }

        public void AddLast(Node newNode)//when current node next is null make that nodes next equal node to add.
        {
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }

        /// <summary>
        /// Go through link list to find node with value that is input
        /// if found return that node, if not return null
        /// </summary>
        /// <param number="value"></param>
        /// <returns></returns>
        public Node Find(int value)//tested to find, and to find null if does not exsist.
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
                Console.Write($"{Current.Value}->");
                Current = Current.Next;
            }
            Console.Write($"{Current.Value}-> null");
        }

    }
}
