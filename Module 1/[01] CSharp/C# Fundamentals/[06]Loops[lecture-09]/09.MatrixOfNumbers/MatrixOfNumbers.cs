/*Problem 9.	Matrix of Numbers
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
and prints a matrix like in the examples below. Use two nested loops.
 */
namespace MatrixOfNumbers
{
    using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter N -> N<20: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 1 + i; j <= n + i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
