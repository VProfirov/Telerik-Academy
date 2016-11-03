/*Problem 7.	Calculate N! / (K! * (N-K)!)
In combinatorics, the number of ways to choose k different members out of a group of n different elements
(also known as the number of combinations) is calculated by the following formula:
 * http://en.wikipedia.org/wiki/Combination
 For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
Try to use only two loops. 
 * Examples:
n	k	n! / (k! * (n-k)!)
3	2	3
4	2	6
10 	6	210
52	5	2598960

 */
namespace CalculateNKPartTwo
{
    using System;
    using System.Numerics;

    class CalculateNKPartTwo
    {
        static void Main()
        {
            Console.Write("Please, enter a whole number, bigger from 1 for K = ");
            string numberStr = Console.ReadLine();
            int numK = int.Parse(numberStr);
            Console.Write("Enter other whole number, bigger from K for N = ");
            numberStr = Console.ReadLine();
            int numN = int.Parse(numberStr);
            if (numK < 2 || numN < 3 || numN <= numK || numK >= 100 || numN >= 100)
            {
                Console.WriteLine("Error - Invalid Input !!!");
            }
            else
            /* The factorial function (symbol: !) means to multiply a series of descending
             * natural numbers. That means N! = N * (N - 1) * (N - 2) * ... * 1 also and
             * K! = K * (K - 1) * (K - 2) * ... * 1.
             * If N > K, K! is Subset of N!, wich means:
             * N! = N * (N - 1) * (N - 2) * ... * (K + 1) * K!
             * To optimize time and performance of this application, we will reduce initial
             * formula from task conditions  RESULT = N! / (K! * (N - K)!)  to next:            
             * 1) = First loop multiplay numbers from N to K + 1;
             * 2) = Second loop calculate Factorial of (N - K)!;
             * RESULT = 1) / 2) . Example: N=7 and K=4, RESULT = 35.   */
            {
                BigInteger factorialNtoK = 1;
                for (int i = numN; i > numK; i--)
                {
                    factorialNtoK *= i;
                }

                BigInteger dividerFactorial = 1;
                for (int j = 2; j <= (numN - numK); j++)
                {
                    dividerFactorial *= j;
                }

                BigInteger resultDivision = factorialNtoK / dividerFactorial;
                Console.WriteLine("The result from that factorials division is:");
                Console.WriteLine("RESULT = {0} !", resultDivision);
            }
            Console.ReadLine();
        }
    }
}
