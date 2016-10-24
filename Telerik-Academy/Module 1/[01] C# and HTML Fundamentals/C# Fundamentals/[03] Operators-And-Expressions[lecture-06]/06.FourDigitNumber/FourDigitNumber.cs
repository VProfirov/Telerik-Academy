/*Problem 6.	Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
•	Prints on the console the number in reversed order: dcba (in our example 1102).
•	Puts the last digit in the first position: dabc (in our example 1201).
•	Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0. 
 * Examples:
 
 n	    sum of digits |	reversed  |	last digit in front	  |  second and third digits exchanged
2011	    4	         1102	            1201	                        2101
3333	    12	         3333	            3333	                        3333
9876	    30	         6789	            6987	                        9786

 */

namespace FourDigitNumber
{
    using System;

    class FourDigitNumber
    {
        static void Main()
        {
            int numberABCD = int.Parse(Console.ReadLine());
            int fourthDigit;
            int thirdDigit;
            int secondDigit;
            int firstdigit;

            fourthDigit = numberABCD % 10;
            thirdDigit = (numberABCD / 10) % 10;
            secondDigit = (numberABCD / 100) % 10;
            firstdigit = (numberABCD / 1000) % 10;

            Console.WriteLine("The sum of the digits is : {0}", (fourthDigit+thirdDigit+secondDigit+firstdigit));

            string first = firstdigit.ToString();
            string second = secondDigit.ToString();
            string third = thirdDigit.ToString();
            string fourth = fourthDigit.ToString();

            Console.WriteLine("The digits in reversed order: {3}{2}{1}{0}", first, second, third, fourth);
            Console.WriteLine("Last digit in first position: {3}{0}{1}{2}", first, second, third, fourth);
            Console.WriteLine("The second and third digits exchanged: {0}{2}{1}{3}", first, second, third, fourth);            
        }
    }
}