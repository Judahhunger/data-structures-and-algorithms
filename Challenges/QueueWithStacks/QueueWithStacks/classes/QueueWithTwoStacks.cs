using StackAndQueue.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.classes
{
    public class QueueWithTwoStacks
    {
        public Stack EnqueueStack { get; set; }
        public Stack DequeueStack { get; set; }

        public QueueWithTwoStacks()
        {
            EnqueueStack = new Stack();
            DequeueStack = new Stack();
        }
        /// <summary>
        /// method to put values into the first stack / first in last out
        /// </summary>
        /// <param name="node"></param>
        public void Enqueue(Node node)
        {
            EnqueueStack.Push(node);
        }

       
        /// <summary>
        /// if there is value from dequeue method will check if there is a value in the stack to dequeue stack
        /// if there is, will pop it, if not then will push the enqueue stack to dequeue stack and pop the first value
        /// to make it like a queue first in first out. throw the error when both stacks empty.
        /// </summary>
        /// <returns></returns>
        public Node Dequeue()
        {

            try
            {
                if (DequeueStack.Peak() == null)
                {
                    while (EnqueueStack.Peak() != null)
                    {
                        DequeueStack.Push(EnqueueStack.Pop());
                    }
                    return DequeueStack.Pop();
                }
                return DequeueStack.Pop();
            }
            catch (NullReferenceException nr)
            {
                throw nr;
            }
           
        }
    }
}
