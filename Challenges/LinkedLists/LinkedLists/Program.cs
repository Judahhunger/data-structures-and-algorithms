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
            Node peanutButter = new Node(3);
            peanutButter = "peanut butter";

            Node jelly = new Node(2);
            jelly.ThisSays = " jelly";

            Node topSliceOfBread = new Node(1);
            topSliceOfBread.ThisSays = "It's ";

            Node bottomSliceOfBread = new Node(4);
            bottomSliceOfBread.ThisSays = " Time!!";

            Node cutOffCrust = new Node(5);
            cutOffCrust.ThisSays = "It's peanut butter jelly time!!";

            //Make instance of LinkList
            LinkList myLinkList = new LinkList(bottomSliceOfBread);
            //put bottom of bread first to start to make sandwitch

            myLinkList.Add(topSliceOfBread);//add top of sandwitch

            myLinkList.AddAfter(peanutButter, topSliceOfBread);// add jelly after top of bread. 

            myLinkList.AddBefore(jelly, bottomSliceOfBread);//add penut butter before bottom slice of bread


            myLinkList.AddLast(cutOffCrust);//last cut off crust

            myLinkList.Print();
            Console.ReadLine();
        }

    }
}
