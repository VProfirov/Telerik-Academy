/*Problem 9.	Sum of n Numbers
Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
Note that you may need to use a for-loop.
 * Examples: 
 
numbers  sum    numbers	sum     numbers	sum
3        90     5       6,5     1       1
20              2               1
60              -1
10              -0,5
                4
                2

 */

namespace SumOfNNumbers
{
    using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("Enter your loop length: ");
            int length = int.Parse(Console.ReadLine());


            double result = 0;

            for (double i = 0; i < length; i++)
            {
                Console.Write("Number [{0}]: ", i);
                double number = double.Parse(Console.ReadLine());

                result += number;
            }

            Console.WriteLine("Sum of these numbers is " + result);
        }
    }
}
