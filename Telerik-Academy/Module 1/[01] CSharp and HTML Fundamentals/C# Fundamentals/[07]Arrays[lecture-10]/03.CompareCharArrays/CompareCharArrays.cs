/* Write a program that compares 
 * two char arrays lexicographically (letter by letter).
 */
namespace CompareCharArrays
{
    using System;

    public class CompareCharArrays
    {
        public static void Main()
        {
            // Test Arrays
            char[] firstArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'r' };
            char[] secondArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            // Check
            bool areLexiEqual = true;

            // length check
            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        areLexiEqual = false;
                    }
                }

                Console.WriteLine("The arrays are equal: {0} .", areLexiEqual);
            }
            else
            {
                areLexiEqual = false;
                Console.WriteLine("The arrays are equal: {0} .", areLexiEqual);
            }
        }
    }
}