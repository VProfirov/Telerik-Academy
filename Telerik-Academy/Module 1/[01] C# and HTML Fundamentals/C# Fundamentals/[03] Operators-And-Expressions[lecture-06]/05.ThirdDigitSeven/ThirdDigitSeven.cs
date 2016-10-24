/*Problem 5.	Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7.
 * Examples:
 
 n	    Third digit 7?
5	        false
701	        true
9703	    true
877	        false
777877	    false
9999799	    true


 */

namespace ThirdDigitSeven
{
    using System;

    class ThirdDigitSeven
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int containerOfThird;
            //moving to 3th position
            containerOfThird = number / 100;

            //checking if the 3th position is seven
            if (containerOfThird % 10 == 7)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}