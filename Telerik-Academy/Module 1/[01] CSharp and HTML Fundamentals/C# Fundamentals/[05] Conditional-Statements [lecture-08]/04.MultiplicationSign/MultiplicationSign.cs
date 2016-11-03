/*Problem 4.	Multiplication Sign
Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
* Examples:
a	b	    c	    result
5	2	    2	    +
-2	-2	    1	    +
-2	4	    3	    -
0	-2.5	4	    0
-1	-0.5	-5.1	-

*/

namespace MultiplicationSign
{
    using System;

    class MultiplicationSign
    {
        // making a method for checking the number of positive signs
        // in a way a counter for the signs
        public static int SignChecker(double number)
        {
            if (number > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static void Main()
        {
            Console.WriteLine("Write three integer numbers to see the sign of their product.");
            Console.Write("Enter number A : ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Enter number B : ");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("Enter number C : ");
            double numberC = double.Parse(Console.ReadLine());

            // do if else for all conditions possible ...
            //if ((numberA == 0) || (numberB == 0) || (numberC == 0))
            //{
            //    Console.WriteLine(0);
            //}
            //else if ((numberA < 0) && (numberB < 0) && (numberC < 0))
            //{
            //   //-
            //}
            //else if ((numberA < 0) && (numberB < 0) && (numberC > 0))
            //{
            //    //+
            //}
            //else if ((numberA < 0) && (numberB > 0) && (numberC > 0))
            //{
            //    //-
            //}
            //else if((numberA > 0) && (numberB > 0) && (numberC > 0))
            //{
            //    //+
            //} 
            // ... all of them .... OR -->

            // cointainer for the values of the checks
            int sign = 0;

            // adding the checks
            sign = sign + SignChecker(numberA);
            sign = sign + SignChecker(numberB);
            sign = sign + SignChecker(numberC);

            // making the condition for the final check of the simbol of the sum

            // if ant of the numbers is = 0
            if (numberA == 0 || numberB == 0 || numberC == 0)
            {
                Console.WriteLine("0");
                Console.WriteLine("The product is ZERO");
                Console.WriteLine();
            }
            // here we can make this check for any count of numbers just checking if the sign is odd (positive); even (negative)
            else if (sign == 1 || sign == 3) // else if (sign % 2 != 0)
            {
                Console.WriteLine("+");
                Console.WriteLine("The product is POSITIVE");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("-");
                Console.WriteLine("The product is NEGATIVE");
                Console.WriteLine();
            }
        }
    }
}