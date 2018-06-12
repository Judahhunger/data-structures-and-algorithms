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
            Node penutButter = new Node(3);
            Node jelly = new Node(2);
            Node topSliceOfBread = new Node(1);
            Node bottomSliceOfBread = new Node(4);
            Node cutOffCrust = new Node(5);

            //Make instance of LinkList
            LinkLists myLinkList = new LinkLists(bottomSliceOfBread);
            //put bottom of bread first to start to make sandwitch
            
            myLinkList.Add(topSliceOfBread);//add top of sandwitch
            
            myLinkList.AddAfter(jelly, topSliceOfBread);// add jelly after top of bread. 
           
            myLinkList.AddBefore(penutButter, bottomSliceOfBread);//add penut butter before bottom slice of bread
            
            
            myLinkList.AddLast(cutOffCrust);//last cut off crust

            myLinkList.Print();
            Console.ReadLine();
        }

    }
}
