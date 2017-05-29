/*Problem 4.	Number Comparer
Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements. 
 * Examples:

 a	    b	    greater
5	    6	    6
10	    5	    10
0	    0	    0
-5	    -2	    -2
1.5	    1.6	    1.6

 */

namespace NumberComparer
{
    using System;

    class NumberComparer
    {
        static void Main()
        {
            // Using a method

            //Console.Write("Please enter the first number:");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.Write("Please enter the second number:");
            //int secondNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine("The greater number is : {0}", Math.Max(firstNumber, secondNumber));

            //--------------------------------------------------------------------------------------

            // Using "?:" operator

            Console.WriteLine("This is program that gets two numbers from the console");
            Console.WriteLine("and prints the greater of them.");
            Console.WriteLine();

            Console.Write("Please enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string a = Convert.ToString(firstNumber);
            string b = Convert.ToString(secondNumber);

            string equal = "The numbers are equal";

            Console.Write("Greater : ");
            Console.Write((firstNumber == secondNumber) ? equal : (firstNumber > secondNumber ? a : b));
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine((firstNumber == secondNumber) ? equal : (firstNumber > secondNumber ? "The FIRST number is greater!" : "The SECOND number is greater!"));

            Console.WriteLine();
        }
    }
}
