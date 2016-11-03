/*Problem 6.	The Biggest of Five Numbers
Write a program that finds the biggest of five numbers by using only five if statements. 
* Examples:
a	    b	    c	    d       e       biggest
5	    2	    2	    4	    1	    5
-2	    -22	    1	    0	    0	    1
-2	    4	    3	    2	    0	    4
0	    -2.5	0	    5	    5	    5
-3	    -0.5	-1.1	-2	    -0.1	-0.1


*/

namespace BiggestOfFiveNumbers
{
    using System;

    class BiggestOfFiveNumbers
    {
        // creating a method to compare TWO numbers
        public static double BiggestNumber(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            //// else if (secondNumber > firstNumber) -> this is to specify if 2nd>1st, BUT exlucdes 2nd=1st
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
            
            Console.Write("Enter the THIRD number : ");
            double fourthNum = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the THIRD number : ");
            double fifthdNum = double.Parse(Console.ReadLine());
            Console.WriteLine();

            // Test values
            // double firstNum = -3;
            // double secondNum = -0.5;
            // double thirdNum = -1.1;
            // double fourthNum = -2;
            // double fifthNum = -0.1;

            double biggestNum = 0;
            //// utilising the method for comapring TWO numbers
            biggestNum = BiggestNumber(firstNum, secondNum);
            //// adding the next number at the back, while using the result of the first comparison in the front -> and making a comparison
            biggestNum = BiggestNumber(biggestNum, thirdNum);
            biggestNum = BiggestNumber(biggestNum, fourthNum);
            biggestNum = BiggestNumber(biggestNum, fifthdNum);

            Console.WriteLine("The biggest number of the five is --> {0}", biggestNum);
        }
    }
}