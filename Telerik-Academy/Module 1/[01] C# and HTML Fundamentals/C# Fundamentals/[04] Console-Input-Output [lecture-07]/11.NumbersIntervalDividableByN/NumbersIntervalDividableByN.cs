/*Problem 11.	* Numbers in Interval Dividable by Given Number
 
Write a program that reads two positive integer numbers and 
prints how many numbers p exist between them such that the reminder of the division by 5 is 0. 
 * Examples:
start	end	    p	comments
17	    25	    2	20, 25

 */

namespace NumbersIntervalDividableByN
{
    using System;

    class NumbersIntervalDividableByN
    {
        static void Main()
        {
            Console.WriteLine("This programe calculates how many numbers p exist");
            Console.WriteLine("between two integer numbers such that ");
            Console.WriteLine("the reminder of the division by 5 is 0 (inclusive)");
            Console.WriteLine();

            Console.Write("Please enter the start number: ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please enter the end number: ");
            int endNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int firstNumber = startNumber / 5;
            int secondNumber = endNumber / 5;

            int counterDivisible = firstNumber - secondNumber;

            //if startnumber%5 == 0 and endNumber % == 0 (+1)
            if ((startNumber % 5 == 0) || (endNumber % 5 == 0))
            {
                Console.WriteLine("There are {0} numbers that are dividable by 5", Math.Abs(counterDivisible) + 1 );
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There are {0} numbers that are dividable by 5", Math.Abs(counterDivisible));
                Console.WriteLine();
            }
            
        }
    }
}
