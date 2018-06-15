using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            implementLinkList();
        }
        
        static void implementLinkList()
        {
            //Make nodes to put into linklist
            Node node3 = new Node(3);
            Node node2 = new Node(2);
            Node node1 = new Node(1);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node = new Node(0);

            //Make instance of LinkList
            LinkLists myLinkList = new LinkLists(node3);

            myLinkList.Add(node2);//add in front
            myLinkList.Add(node);

            myLinkList.AddAfter(node4, node3); //add after

            myLinkList.AddBefore(node1, node2); // add before

            myLinkList.AddLast(node5); //add last

            myLinkList.Print();// print nodes

            Console.ReadLine();
        }

    }
}
