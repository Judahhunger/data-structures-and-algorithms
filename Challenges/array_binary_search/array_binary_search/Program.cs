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
        /// <summary>
        /// Method takes in an int array and a key value number
        /// It finds the index for the middle of the array 
        /// If the middle is equal to the key then it returns the index
        /// It then compare and changes the middle of array depending on if index is more or less and makes new middle untill value of key is found
        /// If value of key is not found it then return -1
        /// </summary>
        /// <param name="givenArray"></param>
        /// <param name="key"></param>
        /// <returns>index position of key or if key is not in array -1</returns>
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
