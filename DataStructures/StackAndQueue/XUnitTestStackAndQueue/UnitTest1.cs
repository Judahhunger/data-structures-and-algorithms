using System;
using Xunit;
using StackAndQueue;
using StackAndQueue.classes;

namespace XUnitTestStackAndQueue
{
    public class UnitTest1
    {
        /// <summary>
        /// Test for null on top of stack if stack is empty.
        /// </summary>
        [Fact]
        public void TestStackPeakOnEmpty()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Peak());
        }

        /// <summary>
        /// push two nodes into stack and checks that the top node is last and therefore on top
        /// </summary>
        [Fact]
        public void TestPushIntoStack()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);

            Stack stack = new Stack();
            stack.Push(one);
            stack.Push(two);

            Assert.Equal(two, stack.Top);
        }

        /// <summary>
        /// tests two nodes into stack and poped the top off so the first node into stack is now top
        /// with first in last out.
        /// </summary>
        [Fact]
        public void TestPopOffOneFromStack()
        {
            Node one = new Node(1);
            Node two = new Node(2);

            Stack stack = new Stack();
            stack.Push(one);
            stack.Push(two);

            
            Assert.Equal(stack.Pop(), two);
            Assert.Equal(one.Value, stack.Top.Value);
        }

        /// <summary>
        /// put 3 nodes into stack and with peak should be able to call it to get top node
        /// and make sure it is not removed from stack by calling it again in assert
        /// </summary>
        [Fact]
        public void TestPeakWithValue()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);

            Stack stack = new Stack();
            stack.Push(one);
            stack.Push(two);
            stack.Push(three);
            stack.Peak();

            Assert.Equal(stack.Peak(), stack.Top);
            
        }

       
        //****End of stack tests begining of Queue tests****

        /// <summary>
        /// make empty queue and test peak to make sure it returns null.
        /// </summary>
        [Fact]
        public void TestPeakOnEmptyQueue()
        {
            Queue queue = new Queue();
            Assert.Null(queue.Peak());
        }


        /// <summary>
        /// Test to make sure the first node is assigned to front and rear
        /// peak to make sure node is in queue as front node.
        /// </summary>
        [Fact]
        public void TestEnqueueForFirstNode()
        {
            Node one = new Node(1);

            Queue queue = new Queue();

            queue.Enqueue(one);
            Assert.Equal(one, queue.Front);
            Assert.Equal(one, queue.Rear);
            Assert.Equal(queue.Front, queue.Peak());
        }

        /// <summary>
        /// test to make sure first node is at front of queue
        /// last node is rear of queue
        /// when peak is used first node is at front.
        /// </summary>
        [Fact]
        public void TestRearAndFrontNodesInQueue()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);

            Queue queue = new Queue();
            queue.Enqueue(one);
            queue.Enqueue(two);
            Assert.Equal(two, queue.Rear);//make sure that when second node is added it'll be rear
            Assert.NotEqual(two, queue.Front);//make sure second node is not assigned to front.
            queue.Enqueue(three);

            Assert.Equal(one, queue.Front);//make sure first node stays in as front
            Assert.Equal(three, queue.Rear);//make sure last node is now rear.
        }

        /// <summary>
        /// place 3 nodes into queue
        /// as they dequeue make sure correct output with node value
        /// and next node is now front
        /// when no nodes are left check to make sure by peaking and node is null.
        /// </summary>
        [Fact]
        public void TestDequeue()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Queue queue = new Queue();
            queue.Enqueue(one);
            queue.Enqueue(two);
            queue.Enqueue(three);

            Assert.Equal(queue.Dequeue(), one);//dequeue first node and make sure it matches with first node added
            Assert.Equal(two, queue.Front);//make sure second node added is new front
            Assert.Equal(queue.Dequeue(), two);//dequeue second node
            Assert.Equal(three, queue.Front);//make sure third node is new front
            Assert.Equal(queue.Dequeue(), three);//dequeue third node
            Assert.Null(queue.Peak());//check to see if all three nodes are removed
            
        }
    }
}
