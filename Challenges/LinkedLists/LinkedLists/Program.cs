using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            implementLinkListSandwitch();
        }
        
        static void implementLinkListSandwitch()
        {
            //Make nodes to put into linklist
            Node penutButter = new Node(4);
            Node jelly = new Node(5);
            Node topSliceOfBread = new Node(35);
            Node bottomSliceOfBread = new Node(16);
            Node cutOffCrust = new Node(7);

            //Make instance of LinkList
            LinkLists myLinkList = new LinkLists(bottomSliceOfBread);
            //put bottom of bread first to start to make sandwitch
            
            myLinkList.Add(topSliceOfBread);//add top of sandwitch
            
            myLinkList.AddAfter(jelly, topSliceOfBread);// add jelly after top of bread. 
            myLinkList.Print();
            myLinkList.AddBefore(penutButter, bottomSliceOfBread);//add penut butter before bottom slice of bread
            myLinkList.Print();
            Console.WriteLine("3");
            myLinkList.AddLast(cutOffCrust);//last cut off crust

            Console.WriteLine(jelly);
            
            myLinkList.Print();
        }

    }
}
