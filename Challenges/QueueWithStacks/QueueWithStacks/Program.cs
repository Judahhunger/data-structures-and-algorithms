using QueueWithStacks.classes;
using StackAndQueue.classes;
using System;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueWithStacks();
        }

        /// <summary>
        /// Make first input of nodes then second one and queue with two stacks. called method to dequeue and catch error on empty stacks
        /// added first inputs to queue, called method to make sure first node was getting returned in first in first out order through
        /// flipping stacks, added second input and called all outputs in order of first in first out.
        /// </summary>
        static void QueueWithStacks()
        {
            //first set to add to que before a dequeue
            Node nodeOne = new Node(1);
            Node nodeTwo = new Node(2);
            Node nodeThree = new Node(3);
            Node nodeFour = new Node(4);

            //second set to add after a dequeue
            Node nodeFive = new Node(5);
            Node nodeSix = new Node(6);

            //make new instance of the double stack queue
            QueueWithTwoStacks testStacks = new QueueWithTwoStacks();

            //test to catch error on empty stacks
            TestDequeue(testStacks);

            //enqueue the first set of inputs
            testStacks.Enqueue(nodeOne);
            testStacks.Enqueue(nodeTwo);
            testStacks.Enqueue(nodeThree);
            testStacks.Enqueue(nodeFour);
            //test to make sure first node value is output
            TestDequeue(testStacks);
            //add more values to input
            testStacks.Enqueue(nodeFive);
            testStacks.Enqueue(nodeSix);
            //make sure order is correct
            while (testStacks.DequeueStack.Peak() != null || testStacks.EnqueueStack.Peak() != null)
            {
                TestDequeue(testStacks);
            }
        }

        /// <summary>
        /// pass in stacks returns to console the value of first input in first input out
        /// wrapped in try catch block so if error is thrown will catch it and return message to user.
        /// </summary>
        /// <param name="myQueueWithStacks"></param>
        public static void TestDequeue(QueueWithTwoStacks myQueueWithStacks)
        {
            //make try catch to capture excetion from both stacks being empty
            try
            {
                Console.WriteLine(myQueueWithStacks.Dequeue().Value);
                Console.ReadLine();
            }
            catch (Exception)
            {

                Console.WriteLine("both stacks are empty nothing to dequeue");
                Console.ReadLine();
            }
        }
    }
}
