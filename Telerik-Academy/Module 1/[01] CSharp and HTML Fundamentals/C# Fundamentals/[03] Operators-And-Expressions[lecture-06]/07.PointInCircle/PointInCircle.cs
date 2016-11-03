/*Problem 7.	Point in a Circle
Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
 * Examples:
 
 x	    y	        inside
0	    1	        true
-2	    0	        true
-1	    2	        false
1.5	    -1	        true
-1.5	-1.5	    false
100	    -30	        false
0	    0	        true
0.2	    -0.8	    true
0.9	    -1.93	    false
1	    1.655	    true

 */

namespace PointInCircle
{
    using System;

    class PointInCircle
    {
        static void Main()
        {
            double x, y;
            bool inside;
            int r = 2;

            Console.Write("Please enter point x = ");
            x = Double.Parse(Console.ReadLine());

            Console.Write("Please enter point y = ");
            y = Double.Parse(Console.ReadLine());

            inside = ((x * x) + (y * y) <= r * r);
            Console.WriteLine(inside);
        }
    }
}