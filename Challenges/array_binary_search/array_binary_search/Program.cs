using System;

namespace array_binary_search
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] myArray = new int[] { 3, 5, 8, 13, 27, 45 };
            int givenKey = 10;

            Console.WriteLine(ArrayBinarySearch(myArray, givenKey));
            Console.ReadLine();
            
        }
        public static int ArrayBinarySearch(int[] givenArray, int key)
        {
            int min = 0;
            int max = givenArray.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (key == givenArray[mid])
                {
                    return mid;
                }
                else if (key < givenArray[mid])
                {
                    max = --mid;
                }
                else
                {
                    min = ++mid;
                }
            }
          
            return -1;
        }
    }
}
