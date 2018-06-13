using System;
using ll_kth_from_end.classes;

namespace ll_kth_from_end
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("app is running");
            ImplementLinkListSandwitch().Print();
            KthElementInLL(0);
            KthElementInLL(1);
            KthElementInLL(2);
            KthElementInLL(3);
            KthElementInLL(4);

            KthElementInLL(5);
            KthElementInLL(-2);
            Console.ReadLine();
        }

        static LinkList ImplementLinkListSandwitch()
        {
            //Make nodes to put into linklist
            Node peanutButter = new Node(2);
            peanutButter.ThisSays = "peanut butter";

            Node jelly = new Node(3)
            {
                ThisSays = " jelly"
            };

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

            return myLinkList;
        }//retruns LinkList in shape of sandwitch.

        static void KthElementInLL(int value)
        {
           string FindKthElement = ImplementLinkListSandwitch().KthElement(value);

            Console.WriteLine(FindKthElement);
        }
        
    }
}
