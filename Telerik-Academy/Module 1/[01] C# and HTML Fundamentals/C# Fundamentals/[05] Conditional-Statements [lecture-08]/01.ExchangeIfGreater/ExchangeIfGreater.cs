/*Problem 1.	Exchange If Greater
Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater
than the second one. As a result print the values a and b, separated by a space. 
 * Examples:
a	    b	    result
5	    2	    2 5
3	    4	    3 4
5.5	    4.5	    4.5 5.5

 */
namespace ExchangeIfGreater
{
    using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("Enter A : ");
            double aNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter B : ");
            double bNumber = double.Parse(Console.ReadLine());

            if (aNumber > bNumber)
            {
                Console.WriteLine(bNumber + " " + aNumber);
            }
            else if (bNumber > aNumber)
            {
                Console.WriteLine(aNumber + " " + bNumber);
                
            }
            //// extra situation if the numbers are equal
            else
            {
                Console.WriteLine(aNumber + " " + bNumber);

                Console.WriteLine("The numbers are EQUAL.");
            }
        }
    }
}