using System;
using Xunit;
using QueueWithStacks.classes;
using StackAndQueue.classes;

namespace TestQueueWithStacks
{
    public class UnitTest1
    {

        /// <summary>
        /// checking stacks to make sure they start empty,
        /// then add to queue by pushing first values into stacks and check to make sure values are going into
        /// first stack and nothing is going into second stack yet.
        /// </summary>
        [Fact]
        public void TestEnqueue()
        {
            QueueWithTwoStacks myTwoStackQueue = new QueueWithTwoStacks();
            //make sure both stacks are empty
            Assert.Null(myTwoStackQueue.EnqueueStack.Peak());//enqueue stack
            Assert.Null(myTwoStackQueue.DequeueStack.Peak());//dequeue stack

            //make nodes to add to imput stack enqueue and check stacks again
            Node one = new Node(1);
            Node two = new Node(2);
            myTwoStackQueue.Enqueue(one);//add one value to queue
            Assert.Equal(myTwoStackQueue.EnqueueStack.Peak(), one);//make sure one is added to enqueue stack
            Assert.Null(myTwoStackQueue.DequeueStack.Peak());//make sure dequeue stack is still empty

            myTwoStackQueue.Enqueue(two);//added second value to queue
            Assert.Equal(myTwoStackQueue.EnqueueStack.Top, two);//make sure the second value is the new top of input stack
            Assert.Null(myTwoStackQueue.DequeueStack.Top);//make sure nothing is in dequeue stack again

        }

        /// <summary>
        /// when dequeue is called while both stacks are empty will throw exception,
        /// we catch it and make sure it is the correct nullReference Exception.
        /// </summary>
        [Fact]
        public void TestDequeueOnEmpty()
        {
            QueueWithTwoStacks myTwoStackQueue = new QueueWithTwoStacks();
            Exception expectedException = null;
            try
            {
                myTwoStackQueue.Dequeue();

            }
            catch (NullReferenceException ex)
            {
                expectedException = ex;
            }
           
            
            
            Assert.NotNull(expectedException);//make sure we catch the exception when error
            
        }

        /// <summary>
        /// makes double stack to act like queue
        /// Test all instances below...
        /// add first items and checks to make sure the stacks are filling up correctly
        /// the first stack gets filled up untill a dequeue is called then the second stacks gets filled and first stack gets empty
        /// if more inputs are added to enque the first stack gets filled again and second stack waits till dequeue before we pop from it
        /// once second stack is empty and dequeue is called again will empty first stack into second stack again.
        /// </summary>
        [Fact]
        public void TestDequeue()
        {
            QueueWithTwoStacks myTwoStackQueue = new QueueWithTwoStacks();
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            myTwoStackQueue.Enqueue(one);//first set first item added to stack
            myTwoStackQueue.Enqueue(two);
            myTwoStackQueue.Enqueue(three);//first set last item added to stack

            Assert.NotNull(myTwoStackQueue.EnqueueStack.Top);//make sure items are in first stack to then switch to second stack
            Assert.Equal(myTwoStackQueue.EnqueueStack.Peak(), three);//make sure last input is first out of first stack
            Assert.Equal(myTwoStackQueue.Dequeue(), one);//make sure first input is first output, meaning last to go into second stack and poped off.
            Assert.Equal(myTwoStackQueue.DequeueStack.Peak(), two); // make sure second input is put to the top of second stack
            Assert.Null(myTwoStackQueue.EnqueueStack.Top);//make sure after first dequue first stack is emptyed

            myTwoStackQueue.Enqueue(four);
            myTwoStackQueue.Enqueue(five);
            Assert.Equal(myTwoStackQueue.EnqueueStack.Peak(), five);//make sure first stack is getting new inputs
            Assert.Equal(myTwoStackQueue.DequeueStack.Peak(), two); //make sure second stack still has left over values untill empty

            myTwoStackQueue.Dequeue();
            myTwoStackQueue.Dequeue();
            Assert.Null(myTwoStackQueue.DequeueStack.Peak());//make sure after all first inputs are dequeue that second stack is empty
            Assert.NotNull(myTwoStackQueue.EnqueueStack.Top);//make sure valuse still excist in first stack

            myTwoStackQueue.Dequeue();
            Assert.Null(myTwoStackQueue.EnqueueStack.Top); //make sure nothing is in first stack after second one is empty and dequeue is called again
            Assert.Equal(myTwoStackQueue.DequeueStack.Peak(), five);//make sure the last item is in second stack waiting to be next in line for output.


        }
    }
}
