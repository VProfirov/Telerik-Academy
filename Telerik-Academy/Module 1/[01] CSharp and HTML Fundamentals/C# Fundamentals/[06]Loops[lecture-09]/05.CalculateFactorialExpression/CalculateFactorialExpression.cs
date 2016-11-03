/*Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
Use only one loop. Print the result with 5 digits after the decimal point.
* Examples :
 n	x	S
3	2	2.75000
4	3	2.07407
5	-4	0.75781

 */
namespace CalculateFactorialExpression
{
    using System;

    class CalculateFactorialExpression
    {        
        static void Main()
        {
            Console.Write("Please, enter a whole positive number for N = ");
            string inputStr = Console.ReadLine();
            int numN = int.Parse(inputStr);
            Console.Write("Enter a whole integer number for X = ");
            inputStr = Console.ReadLine();
            int numX = int.Parse(inputStr);
            if (numN < 1)
            {
                Console.WriteLine("Error - Invalid Number !!!");
            }
            else
            {
                // The formula is Sum = 1 + 1!/X + 2!/X^2 + … + N!/X^N

                double factorialN = 1;
                double numXPowerN = 1;
                double sumOfSequence = 1;
                for (int i = 1; i <= numN; i++)
                {
                    factorialN *= i;
                    numXPowerN *= numX;
                    sumOfSequence += (factorialN / numXPowerN);
                }
                Console.WriteLine("The Sum of sequence of these numbers N and X is SUM = {0:F5} !",
                    sumOfSequence);
            }
            Console.ReadLine();
        }
    }
}
