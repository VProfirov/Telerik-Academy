/*Problem 10.	Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
and out of the rectangle R(top=1, left=-1, width=6, height=2). 
 * Examples:

x	    y	inside K & outside of R
1	    2	    yes
2.5	    2	    no
0	    1	    no
2.5	    1	    no
2	    0	    no
4	    0	    no
2.5	    1.5	    no
2	    1.5	    yes
1	    2.5	    yes
-100	-100    no

 */

namespace PointInsideCircleOusideRe
{
    using System;

    class PointInsideCircleOusideRe
    {
        static void Main()
        {
            double x, y;
            double r = 1.5;
            double circleX = 1;
            double circleY = 1;
            Console.Write("Please enter point x = ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Please enter point y = ");
            y = Double.Parse(Console.ReadLine());
            bool inside = ((x - circleX) * (x - circleX)) + ((y - circleY) * (y - circleY)) <= (r * r);
            bool rectXout = (x >= 5) && (x <= -1);
            bool rectYout = (y >= -1) && (y <= 1);
            if ((rectXout == false && rectYout == false) && inside == true)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Point is inside Circle and Outside Rectangle");
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("Point doesn't match condition inside Circle and Outside Rectangle");
            }
        }
    }
}