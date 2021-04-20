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
            // The solutions work correctly! Focus on: AllCases**
            // NOTE: Further refactoring is needed - this is a 1st run and not a lot of exp in the area existed beforehand.
            AllCasesForPointRelatedToCircleAndRectangle_Solution();
            IsInsideCircleOutsideRectangle_Solution();
        }

        static void IsInsideCircleOutsideRectangle_Solution()
        {
            double x, y;
            double r = 1.5;
            double circleX = 1;
            double circleY = 1;
            Console.Write("Please enter point x = ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Please enter point y = ");
            y = Double.Parse(Console.ReadLine());
            bool insideCircle = ((x - circleX) * (x - circleX)) + ((y - circleY) * (y - circleY)) <= (r * r);
            bool rectXout = (x < -1) || (x > 5);
            bool rectYout = (y > 1) || (y < -1);
            if (insideCircle && (rectXout || rectYout))
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

        static void AllCasesForPointRelatedToCircleAndRectangle_Solution()
        {
            Console.Write("Please enter point x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Please enter point y = ");
            double y = double.Parse(Console.ReadLine());
            double rr = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1));
            double r = Math.Sqrt(rr);
            bool rectangle = ((-1 <= x && x <= 5) && (-1 <= y && y <= 1));
            bool circle = (r <= 1.5d);
            if (rectangle == true && circle == true)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else
            {
                if (rectangle == false && circle == false)
                {
                    Console.WriteLine("outside circle outside rectangle");
                }
                else
                {
                    if (rectangle == true && circle == false)
                    {
                        Console.WriteLine("outside circle inside rectangle");
                    }
                    else
                    {
                        Console.WriteLine("inside circle outside rectangle");
                    }
                }
            }

        }
    }
}
