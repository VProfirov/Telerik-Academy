/*Problem 4.	Rectangles
Write an expression that calculates rectangle’s perimeter and area by given width and height.
 * Examples:

width	height	perimeter	area
3	       4	    14	    12
2.5	       3	    11	    7.5
5	       5	    20	    25
 
*/

namespace Rectangles
{
    using System;

    class Rectangles
    {
        static void Main()
        {
            Console.Write("Enter width of the rectangle : ");
            double widthOfRectangle = double.Parse(Console.ReadLine());
            Console.Write("Enter height of the rectangle : ");
            double heightOfRectangle = double.Parse(Console.ReadLine());

            double perimeterOfRectangle;
            double areaOfRectangle;

            perimeterOfRectangle = 2 * (widthOfRectangle + heightOfRectangle);
            areaOfRectangle = widthOfRectangle * heightOfRectangle;

            Console.WriteLine("The PERIMETER of the rectnagle is : {0}", perimeterOfRectangle);
            Console.WriteLine("The AREA of the rectangle is : {0}", areaOfRectangle);            
        }
    }
}
// NOTES : Formulas for Rectangle
/*
 * Perimeter = 2 × (w + h)
    w = width
    h = height
 * 
 * Area = w × h
    w = width
    h = height
 */