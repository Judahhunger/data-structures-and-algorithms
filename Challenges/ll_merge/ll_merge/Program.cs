using System;
using ll_merge.classes;

namespace ll_merge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

        public void Merge(LinkList firstList, LinkList secondList)
        {
            firstList.Current = firstList.Head;
            secondList.Current = secondList.Head;

            firstList.Runner = firstList.Current.Next;

            while (firstList.Runner.Next != null && secondList.Current.Next != null)
            {

            }
        }
    }
}
