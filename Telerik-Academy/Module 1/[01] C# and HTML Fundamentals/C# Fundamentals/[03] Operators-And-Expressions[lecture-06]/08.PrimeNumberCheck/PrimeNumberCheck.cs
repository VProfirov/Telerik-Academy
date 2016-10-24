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
        static void Main()
        {
            Console.Write("Please enter positive integer number n (n <= 100) : ");

            int number = int.Parse(Console.ReadLine());
            // int number = 1; //positive NOT Prime integer n (n ≤ 100)
            // int number = 2; //positive Prime integer n (n ≤ 100)
            // int number = 3; //positive Prime integer n (n ≤ 100)
            // int number = 4; //positive NOT Prime integer n (n ≤ 100)
            // int number = 13; //positive Prime integer n (n ≤ 100)
            // int number = 14; //positive NOT Prime integer n (n ≤ 100)
            int counter = 0;

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

/* ANOTHER SOLUTION
 
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
                }
            divider++;
            }
            Console.WriteLine("Prime? " + isPrime);
 
 */