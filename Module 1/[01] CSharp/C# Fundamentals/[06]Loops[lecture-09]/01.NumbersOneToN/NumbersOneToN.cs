/*Problem 1.	Numbers from 1 to N
Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, 
on a single line, separated by a space. 
* Examples:
n	output
3	1 2 3
5	1 2 3 4 5

 */
namespace NumbersOneToN
{
    using System;

    class NumbersOneToN
    {
        static void Main()
        {
            Console.WriteLine("This program prints the numbers from 1 to N.");
            Console.WriteLine();
            Console.Write("Please enter the N-th (positive unsigned integer) number : ");
            int numberPrint = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("The list : ");

            if (numberPrint <= 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please try again and enter positive integer,this time !");
                Console.WriteLine();
                Console.WriteLine();
                Main();
            }
            else
            {
                for (int i = 1; i <= numberPrint; i++)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
