/*Problem 3.	Min, Max, Sum and Average of N Numbers
Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below. 
 * Examples:
input	output
2       min = -1
-1      max = 4
4	    sum = 3
        avg = 1.50
 */
namespace MinMaxSumAvarageOfNNumbers
{
    using System;

    class MinMaxSumAvarageOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("The program finds the biggest and the smallest number ");
            Console.WriteLine("of N integer numbers sequence");
            Console.WriteLine();

            Console.Write("How manu numbers do you want to compare : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //starting values
            int biggest = int.MinValue;
            int smallest = int.MaxValue;
            int sum = 0;
            double average = 0;
            

            //reading the numbers loop and calculating the biggest and the smallest
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter the number {0} : ", i);
                int input = int.Parse(Console.ReadLine());
                //figuring out biggest/smallest
                if (input > biggest)
                {
                    biggest = input;
                }
                if (input < smallest)
                {
                    smallest = input;
                }

                sum = sum + input;                 
            }
            average = (double)sum / (double) n;

            Console.WriteLine("Min: {0}", smallest);
            Console.WriteLine("Max: {0}", biggest);
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Avg: {0}", average);
        }
    }
}
