/*Problem 7.	Sort 3 Numbers with Nested Ifs
Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements. Don’t use arrays and the built-in sorting functionality.
 * Examples:
a	    b	    c	    result
5	    1	    2	    5 2 1
-2	    -2	    1	    1 -2 -2
-2	    4	    3	    4 3 -2
0	    -2.5	5	    5 0 -2.5
-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
10	    20	    30	    30 20 10
1	    1	    1	    1 1 1

 */
namespace SortNumbersWithNestedIfs
{
    using System;

    class SortNumbersWithNestedIfs
    {
        static void Main()
        {
            Console.WriteLine("This programe sorts three real numbers");
            Console.WriteLine("in descending order.");
            Console.WriteLine();

            Console.Write("Enter the FIRST number : ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the SECOND number : ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the THIRD number : ");
            double thirdNum = double.Parse(Console.ReadLine());
            Console.WriteLine();

            // Test numbers
            // double firstNum = 4;
            // double secondNum = 101;
            // double thirdNum = 100;

            // Temporary container
            double temp;

            // Ordering the numbers
            if (secondNum > firstNum)
            {
                temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
                if (thirdNum > secondNum)
                {
                    temp = thirdNum;
                    thirdNum = secondNum;
                    secondNum = temp;
                }
                if (secondNum > firstNum)
                {
                    temp = firstNum;
                    firstNum = secondNum;
                    secondNum = temp;
                }
            }
            if (thirdNum > secondNum)
            {
                temp = thirdNum;
                thirdNum = secondNum;
                secondNum = temp;
                if (secondNum > firstNum)
                {
                    temp = firstNum;
                    firstNum = secondNum;
                    secondNum = temp;
                }
            }
            Console.WriteLine("The ordered numbers are as fallows : ");
            Console.WriteLine("{0}, {1}, {2}", firstNum, secondNum, thirdNum);
            Console.WriteLine();
        }
    }
}
