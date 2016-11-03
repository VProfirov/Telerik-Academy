/*Problem 18.	* Trailing Zeroes in N!
Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000. 
* Examples: 
 n	trailing zeroes of n!	explaination
10	2	                    3628800
20	4	                    2432902008176640000

 */
namespace TrailingZeroesInN
{
    using System;
    using System.Numerics;

    class TrailingZeroesInN
    {
        static void Main()
        {
            Console.WriteLine("For given N how many trailing zeros present at the end of the given number N.");
            Console.WriteLine();

            Console.WriteLine("Enter a positive integer number N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            BigInteger factorial = 1;

            BigInteger trailingZeroes = 0;
            int sum = 5; // n/5 + n/25 + n/125 + … = the number of trailing zeroes in N!

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);

            while (n >= sum)
            {
                trailingZeroes += (n / sum);
                sum *= 5;
            }
            Console.WriteLine("The number of the trailing zeroes at the end of ({0}!) is: {1}\n", n, trailingZeroes);
        }
    }
}
