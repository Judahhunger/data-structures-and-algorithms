using System;

namespace reverse_array01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 3, 2, 1 };

            ReverseArray(testArray);

        }


        static int[] ReverseArray(int[] arrayToReverse)
        {
            int indexCounter = 0;
            int[] reversedArray = new int[arrayToReverse.Length];

            for (int i = arrayToReverse.Length - 1; i >= 0; i--)
            {
                reversedArray[indexCounter] = arrayToReverse[i];
                indexCounter++;
            }

            foreach (var item in reversedArray)
            {
                Console.WriteLine(item.ToString());
            }

            return reversedArray;
        }
    }
}
