/*Calculate GCD
Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
 Use the Euclidean algorithm (find it in Internet). 
a	b	GCD(a, b)
3	2	1
60	40	20
5	-15	5

 */
namespace CalculateGCD
{
    using System;

    class CalculateGCD
    {
        static void Main()
        {
            Console.WriteLine("This program calculates the greatest common divisor (GCD) of");
            Console.WriteLine("of given two numbers (using Euclidean algorithm )");

            Console.WriteLine();
            Console.Write("Enter number a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Enter number b: ");
            double b = double.Parse(Console.ReadLine());

            // Exchange values if a < b
            if (a < b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            double result;
            double resultRemainder;

            Console.WriteLine();
            while (true)
            {
                result = a / b;
                resultRemainder = a % b;

                if (resultRemainder != 0)
                {
                    Console.WriteLine("{0} : {1} = {2} ; reminder = {3}", a, b, result, resultRemainder);
                    a = b;
                    b = resultRemainder;
                }
                else
                {
                    Console.WriteLine("The Greatest Common Divider is: {0}", b);
                    break;
                }
            }
        }
    }
}
