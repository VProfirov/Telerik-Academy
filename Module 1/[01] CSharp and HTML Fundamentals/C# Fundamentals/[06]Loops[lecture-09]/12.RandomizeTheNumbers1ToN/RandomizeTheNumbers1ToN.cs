/*Problem 12.	* Randomize the Numbers 1…N
Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
 * Examples:
n	randomized numbers 1…n
3	2 1 3
10	3 4 8 2 6 7 9 1 10 5 

 * Note that the above output is just an example. Due to randomness,
 * your program most probably will produce different results.
 * You might need to use arrays.
 */
namespace RandomizeTheNumbers1ToN
{
    using System;

    class RandomizeTheNumbers1ToN
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Random randomNumbers = new Random();

            for (int i = 1; i <= n; i++)
            {
                Console.Write(randomNumbers.Next(1, n + 1) + " ");
            }

            Console.WriteLine();
        }
    }
}
