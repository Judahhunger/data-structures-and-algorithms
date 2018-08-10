using System;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidationBrackets("stuff() goes {[[]]}").ToString());//should be true
            Console.WriteLine(ValidationBrackets("this ([{ }) should be false").ToString());
            Console.ReadLine();
        }

        public static bool ValidationBrackets(string myString)
        {
            int roundCount = 0;
            int curlyCount = 0;
            int squareCount = 0;
            bool countBool = false;

            char[] mySearchArray = myString.ToCharArray();

            foreach (char item in mySearchArray)
            {
                //check for same count of round brackets
                if (item == '(')
                {
                    roundCount++;
                }
                if (item == ')')
                {
                    if (curlyCount == 1)
                    {
                        return false;
                    }
                    roundCount--;
                }
                //check square brackets
                if (item == '[')
                {
                    squareCount++;
                }
                if (item == ']')
                {
                    squareCount--;
                }
                //check curly brackets
                if (item == '{')
                {
                    curlyCount++;
                }
                if (item == '}')
                {
                    if (roundCount == 1)
                    {
                        return false;
                    }
                    curlyCount--;
                }
            }

            if (curlyCount == 0 && squareCount == 0 && roundCount == 0)
            {
                countBool = true;
            }
            return countBool;
        }
    }
}
