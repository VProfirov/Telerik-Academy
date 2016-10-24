﻿/*Problem 9.	Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b and height h. 
 Examples:

a	    b	    h	    area
5	    7	    12	    72
2	    1	    33	    49.5
8.5	    4.3	    2.7	    17.28
100	    200	    300	    45000
0.222	0.333	0.555	0.1540125

 */

namespace Trapezoids
{
    using System;

    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("This program calculates the area of Trapezoid.");
            Console.WriteLine();

            Console.Write("Please enter side A (integer)  : ");

            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please enter side B (integer)  : ");

            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please enter height H (integer)  : ");

            double height = double.Parse(Console.ReadLine());
            Console.WriteLine();

            //double sideA = 5; // Test values
            //double sideB = 3; // Test values
            //double height = 10; // Test values

            //Calculating Area of Trapezoid
            double area = ((sideA + sideB) * height) / 2;

            Console.WriteLine("The area of the trapezoid is: {0}", area);
            Console.WriteLine();
        }
    }
}