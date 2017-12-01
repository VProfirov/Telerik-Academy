/*Problem 5.	The Biggest of 3 Numbers
Write a program that finds the biggest of three numbers. 
* Examples:
a	    b	    c	    biggest
5	    2	    2	    5
-2	    -2	    1	    1
-2	    4	    3	    4
0	    -2.5	5	    5
-0.1	-0.5	-1.1	-0.1

*/

namespace BiggestOfThreeNumbers
{
    using System;

    class BiggestOfThreeNumbers
    {
        // creating a method to compare TWO numbers
        public static double BiggestNumber(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            ////else if (secondNumber > firstNumber) -> this is to specify if 2nd>1st, BUT exlucdes 2nd=1st
            else 
            {
                return secondNumber;
            }
        }

        static void Main()
        {
            Console.WriteLine("This programes finds the biggest of three numbers.");
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

            // Test values
            //double firstNum = -0.1;
            //double secondNum = -0.5;
            //double thirdNum = -1.1;

            double biggestNum = 0;
            ////utilising the method for comapring TWO numbers
            biggestNum = BiggestNumber(firstNum, secondNum);
            ////adding the next number at the back, while using the result of the first comparison in the front -> and making a comparison
            biggestNum = BiggestNumber(biggestNum, thirdNum);

            Console.WriteLine("The biggest number of the three is --> {0}", biggestNum);
        }
    }
}