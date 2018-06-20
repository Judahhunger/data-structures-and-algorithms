using System;
using ll_merge.classes;

namespace ll_merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] firstInput = { 1, 2, 3, 4 };
            int[] secondInput = { 5, 6, 7, 8 };

            LinkList firstList = MakeMyLinkLists(firstInput);
            LinkList secondList = MakeMyLinkLists(secondInput);
            firstList.Print();
            Console.WriteLine();
            secondList.Print();
            Console.WriteLine();
            ViewMerge(firstList, secondList);
            Console.ReadLine();
            Console.WriteLine(Merge(firstList, secondList));
            Console.WriteLine();
            Console.ReadLine();


        }

       public static LinkList MakeMyLinkLists(int[] arrayOfnums)
        {
            LinkList myLists = new LinkList(new Node(arrayOfnums[0]));
            for (int i = 1; i < arrayOfnums.Length; i++)
            {
                myLists.Add(new Node(arrayOfnums[i]));
            }
            return myLists;
        }

        /// <summary>
        /// Takes in 2 linkedlists merges the second list into the first list
        /// returns the head of the first list.
        /// </summary>
        /// <param name="firstList"></param>
        /// <param name="secondList"></param>
        /// <returns></returns>
        public static Node Merge(LinkList firstList, LinkList secondList)
        {
            firstList.Current = firstList.Head;
            secondList.Current = secondList.Head;

            firstList.Runner = firstList.Current.Next;

            while (firstList.Runner != null && secondList.Current.Next != null)
            {
                firstList.Current.Next = secondList.Current;//first node of L1 points to head of L2
                secondList.Head = secondList.Current.Next;// L2 head is now node 2 in L2
                secondList.Current.Next = firstList.Runner;//L2 node 1 points to runner node 2 in L1
                secondList.Current = secondList.Head;// makes current node L2 from head node for L2
                firstList.Current = firstList.Runner;//L1 current is now runner node 1 L2

                firstList.Runner = firstList.Current.Next;//makes sure runner changes to keep the next value in line of nodes.

            }
            if (firstList.Runner == null)
            {
                firstList.Current.Next = secondList.Head;//if L1 is about to end makes sure the last node from L2 becomes tail
            }
            if (secondList.Current.Next == null)
            {
                firstList.Current.Next = secondList.Current;
                secondList.Current.Next = firstList.Runner;
            }

            return firstList.Head;
        }

        /// <summary>
        /// Same as above just prints the merged list to console.
        /// </summary>
        /// <param name="firstList"></param>
        /// <param name="secondList"></param>
        public static void ViewMerge(LinkList firstList, LinkList secondList)
        {
            firstList.Current = firstList.Head;
            secondList.Current = secondList.Head;

            firstList.Runner = firstList.Current.Next;

            while (firstList.Runner != null && secondList.Current.Next != null)
            {
                firstList.Current.Next = secondList.Current;//first node of L1 points to head of L2
                secondList.Head = secondList.Current.Next;// L2 head is now node 2 in L2
                secondList.Current.Next = firstList.Runner;//L2 node 1 points to runner node 2 in L1
                secondList.Current = secondList.Head;// makes current node L2 from head node for L2
                firstList.Current = firstList.Runner;//L1 current is now runner node 1 L2

                firstList.Runner = firstList.Current.Next;//makes sure runner changes to keep the next value in line of nodes.
                
            }
            if (firstList.Runner == null)
            {
                firstList.Current.Next = secondList.Head;//if L1 is about to end makes sure the last node from L2 becomes tail
            }
            if (secondList.Current.Next == null)
            {
                firstList.Current.Next = secondList.Current;
                secondList.Current.Next = firstList.Runner;
            }
            
            
            LinkList mergedList = new LinkList(firstList.Head);
            mergedList.Print();
            //L1 4-3-2-1
            //L2 8-7-6
            // expected 4-8-3-7-2-6-1-null
        }
    }
}
