using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.classes
{
    class Queue
    {
        /// <summary>
        /// get rear of queue
        /// </summary>
        public Node Rear { get; set; }

        /// <summary>
        /// get front of queue
        /// </summary>
        public Node Front { get; set; }

        /// <summary>
        /// returns front node without removing it from queue
        /// </summary>
        /// <returns></returns>
        public Node Peak()
        {
            return Front;
        }

        /// <summary>
        /// any nodes getting added to queue becomes the rear
        /// if there is no nodes in queue the first one becomes the front.
        /// </summary>
        /// <param name="node"></param>
        public void Enqueue(Node node)
        {
            if (Peak() != null)
            {
                Rear.Next = node;
                Rear = node;
                return;
            }
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Make temp referance to front node in queue
        /// make the next node the front of queue
        /// make temp point to null so no referance connection for garabage collection
        /// returns temp node.
        /// </summary>
        /// <returns>node that was at front of queue</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp;
        }

    }
}
