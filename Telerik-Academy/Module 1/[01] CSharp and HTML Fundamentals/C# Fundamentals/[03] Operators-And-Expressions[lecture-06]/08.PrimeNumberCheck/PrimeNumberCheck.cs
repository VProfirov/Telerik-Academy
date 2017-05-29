/*Problem 8.	Prime Number Check
Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
(i.e. it is divisible without remainder only to itself and 1).
 * Examples:
 
 n	    Prime?
1	    false
2	    true
3	    true
4	    false
9	    false
97	    true
51	    false
-3	    false
0	    false

*/

namespace PrimeNumberCheck
{
    using System;

    class PrimeNumberCheck
    {
        /// <summary>
        /// Every number divisible by 1 and itself is a prime. 1 is not considered a prime
        /// </summary>
        static void Main()
        {
            ///<summary>
            ///Every number divisible by 1 and itself is a prime
            ///</summary>
           
            Console.Write("Please enter positive integer number n (n <= 100) : ");

            int number = int.Parse(Console.ReadLine());
            // int number = 1; //positive NOT Prime integer n (n ≤ 100)
            // int number = 2; //positive Prime integer n (n ≤ 100)
            // int number = 3; //positive Prime integer n (n ≤ 100)
            // int number = 4; //positive NOT Prime integer n (n ≤ 100)
            // int number = 13; //positive Prime integer n (n ≤ 100)
            // int number = 14; //positive NOT Prime integer n (n ≤ 100)
            int counter = 0;

            // Drawback : it goes through all the numbers from 1 to number - more computation then needed
            // NB! starting from i=2 because a check for 1 will be pointless - 1 is not a prime
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }

            //if the counter is (counter >= 2) it will mark all input numbers as primie (dividable by 1 and MORE then itself)
            //if the counter is (counter <= 2) it will mark number 1 as primie, which is not
            if (counter == 2)
            {
                Console.WriteLine(true);
                Console.WriteLine("The number {0} is PRIME", number);
            }
            else
            {
                Console.WriteLine(false);
                Console.WriteLine("The number {0} is NOT PRIME", number);
            }
        }
    }
}

// NOTES :

/* ANOTHER SOLUTION (performance optimized): 
 
 *          Console.Write("Please enter positive integer number n (n <= 100) : ");
            int number = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);
            bool isPrime = true;
            while (isPrime && (divider <= maxDivider))
            {
                if (number % divider == 0)
                {
                    isPrime = false;
                    // no other computation is need, so we exit the loop using "break"
                    // optimization condition : doesn't go through all the numbers until it reaches maxDivider
                    break; 
                }
            divider++;
            }
            Console.WriteLine("Prime? " + isPrime);
 
 */
