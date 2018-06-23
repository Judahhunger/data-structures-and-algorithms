using System;
using Xunit;
using ll_merge;
using ll_merge.classes;
using System.Collections.Generic;

namespace ll_mergeTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMerge()
        {
            LinkList firstList = new LinkList(new Node(5));
            Node node = new Node(4);
            Node node2 = new Node(3);
            Node node3 = new Node(2);
            Node node4 = new Node(1);
            firstList.Add(node);
            firstList.Add(node2);
            firstList.Add(node3);
            firstList.Add(node4);

            LinkList secondList = new LinkList(new Node(6));
            Node node5 = new Node(7);
            Node node6 = new Node(8);
            Node node7 = new Node(9);
            Node node8 = new Node(10);
            firstList.Add(node5);
            firstList.Add(node6);
            firstList.Add(node7);
            firstList.Add(node8);
            

            Assert.Equal(firstList.Head, Program.Merge(firstList, secondList));
        }

        [Fact]
        public void TestMergeFirstListShort()
        {
            LinkList firstList = new LinkList(new Node(5));
            Node node4 = new Node(1);
            firstList.Add(node4);

            LinkList secondList = new LinkList(new Node(6));
            Node node5 = new Node(7);
            Node node6 = new Node(8);
            Node node7 = new Node(9);
            Node node8 = new Node(10);
            firstList.Add(node5);
            firstList.Add(node6);
            firstList.Add(node7);
            firstList.Add(node8);


            Assert.Equal(firstList.Head, Program.Merge(firstList, secondList));
        }

        [Fact]
        public void TestMergeSecondListShort()
        {
            LinkList firstList = new LinkList(new Node(5));
            Node node = new Node(4);
            Node node2 = new Node(3);
            Node node3 = new Node(2);
            Node node4 = new Node(1);
            firstList.Add(node);
            firstList.Add(node2);
            firstList.Add(node3);
            firstList.Add(node4);

            LinkList secondList = new LinkList(new Node(6));
            Node node8 = new Node(10);
            firstList.Add(node8);


            Assert.Equal(firstList.Head, Program.Merge(firstList, secondList));
        }

    }
}
