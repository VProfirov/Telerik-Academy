/*Problem 2.	Numbers Not Divisible by 3 and 7
Write a program that enters from the console a positive integer n and prints all the numbers
from 1 to n not divisible by 3 and 7, on a single line, separated by a space. 
 * Examples:
n	output
3	1 2
10	1 2 4 5 8 10

 */
namespace NumbersNotDevisibleBy3And7
{
    using System;

    class NumbersNotDevisibleBy3And7
    {
        static void Main()
        {
            Console.WriteLine("This Program prints all the numbers from 1 to N,");
            Console.WriteLine("that are not divisible by 3 and 7.");
            Console.WriteLine();

            Console.Write("Please enter the N-th (positive integer) number : ");
            uint nThNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("The list of numbers divisble by 3 and 7 at the same time: ");
            Console.WriteLine();
            
            for (int i = 1; i <= nThNumber; i++)
            {
                ////condition -> divisible by 3 and 7 at the same time
                if ((i % 3 != 0)&&(i% 7!=0))
                {
                    Console.Write(" {0} ", i);                  
                }              
            }
            Console.WriteLine();
        }
    }
}
