/*Problem 1.	Sum of 3 Numbers
Write a program that reads 3 real numbers from the console and prints their sum. 
 * Examples:
 a	    b	    c	    sum
3	    4	    11	    18
-2	    0	    3	    1
5.5	    4.5	    20.1	30.1

 */

namespace SumThreeNumbers
{
    using System;

    class SumThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("This program calculates the sum of 3 real numbers.");
            Console.WriteLine();

            // The sum of the numbers starts at 0
            double sum = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please enter a number : ");

                double currentNumber = double.Parse(Console.ReadLine());

                sum += currentNumber;

            }
            // Printing the sum
            Console.WriteLine();
            Console.WriteLine("The sum of the three real numbers is {0}", sum);
            Console.WriteLine();
        }
    }
}
