using System;
using array_binary_search;
using Xunit;

namespace XUnitTestArray_Binary_Search
{
    public class UnitTest1
    {
        [Fact]
        public void TestForLowerThenMin()
        {
            int[] testArray = new int[] { 2, 4, 9, 12, 19 };
            int testKey = 1;
            Assert.Equal(-1, Program.ArrayBinarySearch(testArray, testKey));
        }

        [Fact]
        public void TestForHigherThenMin()
        {
            int[] testArray = new int[] { 2, 4, 9, 12, 19 };
            int testKey = 50;
            Assert.Equal(-1, Program.ArrayBinarySearch(testArray, testKey));
        }

        [Fact]
        public void TestForInsideArray()
        {
            int[] testArray = new int[] { 2, 4, 9, 12, 19 };
            int testKey = 12;
            Assert.Equal(3, Program.ArrayBinarySearch(testArray, testKey));
        }

        [Fact]
        public void TestForBetweenNums()
        {
            int[] testArray = new int[] { 2, 4, 9, 12, 19 };
            int testKey = 5;
            Assert.Equal(-1, Program.ArrayBinarySearch(testArray, testKey));
        }
    }
}
