/*Problem 1.	Odd or Even Integers
Write an expression that checks if given integer is odd or even. Examples:
n	Odd?
3	true
2	false
-2	false
-1	true
0	false
 */

namespace OddOrEven
{
    using System;

    class OddOrEven
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Enter an integer nubmer:");
            bool vaildNumber = int.TryParse(Console.ReadLine(), out number);

            // Checks if the entered number is integer or number at all
            // If it is (validNumber == true), then continues with the main part of the program
            if (vaildNumber)
            {
                if (number % 2 == 0) // the % and == operators explanatoin at NOTES*
                {
                    Console.WriteLine("The number {0} is EVEN. ; n Odd ? -> " + (number % 2 != 0), number);
                }
                else 
                {
                    // the only message difference is "ODD"
                    Console.WriteLine("The number {0} is ODD. ; n Odd ? -> " + (number % 2 != 0), number);
                }
            }
            else 
            {
                // This is an example for trying to catch an exception of the problem at hand, printing some information
                Console.WriteLine("Enter a valid integer number !");
                // Calls the Main() method in order to start the program again
                Main();
            }
        }
    }
}

// NOTES : 

//example for other "odd or even" programs and explanation for them :
// http://www.dotnetperls.com/odd
// http://bytes.com/topic/c-sharp/answers/268406-how-check-if-integer-even-odd

// The % operator : http://msdn.microsoft.com/en-us/library/0w4e0fzs.aspx

// The == operator: http://msdn.microsoft.com/en-us/library/53k8ybth.aspx