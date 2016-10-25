/*Problem 8.	Catalan Numbers
In combinatorics, the Catalan numbers are calculated by the following formula:
  http://en.wikipedia.org/wiki/Catalan_number
Write a program to calculate the nth Catalan number by given n (1 < n < 100). 

 */
namespace CatalanNumbers
{
    using System;

    class CatalanNumbers
    {
        static double Factorial(double n)
        {
            double nFact = 1;
            for (double i = 1; i <= n; i++)
            {
                nFact = nFact * i;
            }
            return nFact;
        }
        static void Main()
        {
            Console.WriteLine(" The Catalan numbers");
            Console.WriteLine("(2*n)! / (n + 1)! * n!");
            Console.WriteLine("Nth Catalan number by given N");

            Console.WriteLine();
            Console.Write("Enter N: ");
            double n = int.Parse(Console.ReadLine());

            double catalanNumber = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));

            Console.WriteLine();
            Console.WriteLine("Catalan Number = {0}", catalanNumber);
            Console.WriteLine();

            // might be better if Factorial is calculated in BigInteger
        }
    }
}
