/*Problem 3.	Circle Perimeter and Area
Write a program that reads the radius r of a circle and prints its perimeter and area
formatted with 2 digits after the decimal point. 
 Examples:
 
 r	    perimeter	area
2	    12.57	    12.57
3.5	    21.99	    38.48

 */

namespace PerimeterAreaOfCircle
{
    using System;

    class PerimeterAreaOfCircle
    {
        static void Main()
        {
            Console.WriteLine("This programe calculates the perimeter and area using the radius of a circle.");
            Console.WriteLine();

            Console.Write("Please enter the radius of the circle : ");

            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine();

            // Calculates the area
            double area = Math.PI * radius * radius;

            // Calculates the perimeter
            double perimeter = 2 * Math.PI * radius;
            // Printing the perimeter
            Console.WriteLine("The PERIMETER of the circle is : {0:0.00}", perimeter);
            Console.WriteLine();
            
            // Printing the area
            Console.WriteLine("The AREA of the circle is : {0:0.00}", area);
            Console.WriteLine();            
        }
    }
}
