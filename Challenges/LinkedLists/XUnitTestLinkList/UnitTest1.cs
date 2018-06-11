using System;
using Xunit;
using LinkedLists;

namespace XUnitTestLinkList
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNode()
        {
            // arrange
            LinkLists ll = new LinkLists(new Node(4));
            Node node = new Node(8);
            Node node2 = new Node(15);

            //act
            ll.Add(node);
            ll.Add(node2);

            /*
              15 <- 8 <- 4
            */
            //assert
            Assert.Equal(ll.Head.Value, node2.Value);
        }

        [Theory]
        [InlineData(8,8)]
        [InlineData(15, 15)]
        [InlineData(30, 30)]
        [InlineData(19, 19)]
        public void CanFindNodeThatExists(int value, int expected)
        {
            //Arrange
            LinkLists ll = new LinkLists(new Node(4));
            Node node = new Node(8);
            Node node2 = new Node(15);
            Node node3 = new Node(19);
            Node node4 = new Node(30);
            //act
            ll.Add(node);
            ll.Add(node2);
            ll.Add(node3);
            ll.Add(node4);
            //Assert
            Assert.Equal(expected, value);
        }

        [Theory]
        [InlineData(42)]
        [InlineData(65)]
        public void RetrunsNullForNodeThatDoesNotExist(int value)
        {
            //Arrange
            LinkLists ll = new LinkLists(new Node(4));
            Node node = new Node(8);
            Node node2 = new Node(15);
            Node node3 = new Node(19);
            Node node4 = new Node(30);

            //Act
            ll.Add(node);
            ll.Add(node2);
            ll.Add(node3);
            ll.Add(node4);

            Node found = ll.Find(value);

            //Assert
            Assert.Null(found);
        }
    }
}
