/*Problem 10.	Fibonacci Numbers
Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
(at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
 * Note that you may need to learn how to use loops. 
 */

namespace FibonacciNumbers
{
    using System;
    using System.Numerics;

    class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("How many members of the Fibonacci sequence should be printed (positive int) ? ");
            Console.Write("Members : ");
            int nNumbers = int.Parse(Console.ReadLine());

            BigInteger firstNumber = 0;
            BigInteger secondNumber = 1;
            BigInteger sum = 0;                    

            // Cycle from 2nd member ( 1 ) to the 100th member
            
                if (nNumbers == 0)
                {
                    Console.WriteLine();
                }
                else if (nNumbers == 1)
                {
                    Console.WriteLine(firstNumber);
                }
                else if (nNumbers == 2)
                {
                    Console.WriteLine(firstNumber);
                    Console.WriteLine(secondNumber);
                }
                else if (nNumbers > 2)
                {
                    Console.WriteLine(firstNumber);
                    Console.WriteLine(secondNumber);

                    for (int i = 2; i < nNumbers; i++)
                    {
                        sum = firstNumber + secondNumber;
                        firstNumber = secondNumber;
                        secondNumber = sum;
                        Console.WriteLine(sum);
                    }
                    
                }  
            
        }
    }
}
