/*Problem 7.	Sum of 5 Numbers
Write a program that enters 5 numbers (given in a single line, separated by a space),
calculates and prints their sum. 
 *  Examples:

numbers	    sum		numbers	        sum		numbers	            sum
1 2 3 4 5	15		10 10 10 10 10	50		1.5 3.14 8.2 -1 0	11.84

 */

namespace SumThreeNumbers
{
    using System;

    class SumThreeNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();

            double sum = 0;

            string[] numbersAsStrings = input.Split(' ');
            for (int i = 0; i < numbersAsStrings.Length; i++)
            {
                sum += double.Parse(numbersAsStrings[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
