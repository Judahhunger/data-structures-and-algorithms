using StackAndQueue.classes;
using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            StackPeak();
            QueuePeak();
        }


        static Stack MakeStack()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
 
            Stack myStack = new Stack();
            
            myStack.Push(one);
            myStack.Push(two);
            myStack.Push(three);
            myStack.Push(four);
            myStack.Push(five);
            Console.WriteLine($"Stack made with nodes 1-5 and the top node is currently = {myStack.Top.Value}");
            Console.ReadLine();
            return myStack;
        }

        static Stack PopTwiceFromStack()
        {
            Stack stack = MakeStack();
            stack.Pop();
            stack.Pop();
            Console.WriteLine($"Popped twice from stack and current top is = {stack.Top.Value}");
            Console.ReadLine();
            return stack;
        }

        static void StackPeak()
        {
            Stack stack = PopTwiceFromStack();
            Console.WriteLine($"peak at first node and it's value is {stack.Peak().Value}");

            while (stack.Peak() != null)
            {
                Console.WriteLine($"using Peak() while top is not null, Node next to pop off stack = {stack.Top.Value}");
                stack.Pop();
                Console.ReadLine();
            }
            if (stack.Peak() == null)
            {
                Console.WriteLine($"Stack is empty");
                Console.ReadLine();
                return;
            }
        }

        static Queue MakeQueueWithEnqueue()
        {
            Node qone = new Node(6);
            Node qtwo = new Node(7);
            Node qthree = new Node(8);
            Node qfour = new Node(9);
            Node qfive = new Node(10);

            Queue queue = new Queue();
            queue.Enqueue(qone);
            queue.Enqueue(qtwo);
            queue.Enqueue(qthree);
            queue.Enqueue(qfour);
            queue.Enqueue(qfive);
            Console.WriteLine("queue with nodes 6-10");
            Console.WriteLine($"The Front of the queue is {queue.Front.Value} and the Rear of queue is {queue.Rear.Value}");
            Console.ReadLine();
            return queue;
        }

        static Queue QueueDequeue()
        {
            Queue queue = MakeQueueWithEnqueue();

            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine($"Dequeue twice and now front of queue is {queue.Front.Value} and the rear is {queue.Rear.Value}");
            Console.ReadLine();
            return queue;
        }

        static void QueuePeak()
        {
            Queue queue = QueueDequeue();

            while (queue.Peak() != null)
            {
                Console.WriteLine($"while using peak() if the front node is not null will Dequeue the front currently {queue.Front.Value}");
                Console.ReadLine();
                queue.Dequeue();
            }
            if (queue.Peak() == null)
            {
                Console.WriteLine("No nodes in Queue Front is null");
                Console.ReadLine();
                return;
            }
        }

    }
}
