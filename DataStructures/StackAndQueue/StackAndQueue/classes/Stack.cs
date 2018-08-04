using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.classes
{
    public class Stack
    {
      
        /// <summary>
        /// Gets the top node of stack
        /// </summary>
        public Node Top { get; set; }

        /// <summary>
        /// will push node into stack and make that node new top
        /// </summary>
        /// <param name="node"></param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// make temp referance to top node
        /// make new top with the next node
        /// returns temp referance of the old top
        /// removes pointer so temp no longer points to top of stack. 
        /// </summary>
        /// <returns>Node of top of stack and removes from stack</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// returns the top node but does not remove it from stack.
        /// </summary>
        /// <returns></returns>
        public Node Peak()
        {
            return Top;
        }

    }
}
