/*Problem 6.	Quadratic Equation
Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
and solves it (prints its real roots).
 * Examples:

 a	    b	    c	    roots
 2	    5	    -3	    x1=-3; x2=0.5
-1	    3	    0	    x1=3; x2=0
-0.5	4	    -8	    x1=x2=4
5	    2	    8	    no real roots

 
 */

namespace QuadraticEquation
{
    using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("This programe solves quadratic equation ax^2+bx+c=0 .");
            Console.WriteLine();

            Console.Write("Please enter variable \"a\" : ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please enter variable \"b\" : ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please enter variable \"c\" : ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            // Check if a = 0
            if (a == 0)
            {
                double result = -(c / b);
                Console.WriteLine("There is one root - x1 = {0}", result);
            }
            // Declaring the discriminant
            double discriminant = (b * b) - (4 * a * c);

            // Discriminant conditions for  >0 and =0
            if (discriminant > 0)
            {
                double xOne = (-b - Math.Sqrt(discriminant)) / (2 * a);
                double xTwo = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("There are two real roots - x1: {0} and x2: {1}", xOne, xTwo);
            }
            else if (discriminant == 0)
            {
                double xOne = (-b / (2 * a));
                Console.WriteLine("There is one real root -> x1: {0}", xOne);
            }
            else
            {
                Console.WriteLine("There are no real roots");
            }
        }
    }
}
