using System;
using Xunit;
using ll_kth_from_end;
using ll_kth_from_end.classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, "This node is 4 and 0 from end")]//test find last node aka first postion kthElement
        [InlineData(3, "This node is 19 and 3 from end")]//test to find middle node
        [InlineData(4, "This node is 30 and 4 from end")]//test to find last node from end.
        [InlineData(5, "Not enough nodes in List for input")]//test for value is greater then number of nodes.
        [InlineData(-1, "Please enter a positive number")]//test to see if the number entered was positive.
        //maybe make one to catch sting or error input later.
        public void FinedKthElementTest(int value, string expected)
        {
            LinkList ll = new LinkList(new Node(4));
            Node node = new Node(7);
            Node node2 = new Node(15);
            Node node3 = new Node(19);
            Node node4 = new Node(30);
            //act
            ll.Add(node);
            ll.Add(node2);
            ll.Add(node3);
            ll.Add(node4);
            //30-->19-->15-->7-->4-->null
           
            //Assert
            Assert.Equal(expected, ll.KthElement(value));
        }
    }
}
