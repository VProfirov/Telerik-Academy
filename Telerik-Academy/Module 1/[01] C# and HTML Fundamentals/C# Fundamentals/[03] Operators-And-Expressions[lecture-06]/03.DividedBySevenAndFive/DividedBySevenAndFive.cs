/*Problem 3.	Divide by 7 and 5
Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:

n	Divided by 7 and 5?
3	false
0	false
5	false
7	false
35	true
140	true

 */

namespace DividedBySevenAndFive
{
    using System;

    class DividedBySevenAndFive
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 35 == 0)
            {
                Console.WriteLine(number % 35 == 0);
                Console.WriteLine();
                Console.WriteLine("The number CAN be divided by 5 and 7");           
            }
            else
            {
                Console.WriteLine(number % 35 == 0);
                Console.WriteLine();
                Console.WriteLine("The number can NOT be divided by 5 and 7");                
            }
        }
    }
}

// NOTES : if you leav the simple code only :

            //if (number % 35 == 0)
            //{
            //    Console.WriteLine(number % 35 == 0);       
            //}
            //else
            //{
            //    Console.WriteLine(number % 35 == 0);              
            //}

// then Visual Studio will underline it with green notifying you that the if and the else parts are identical
// That does not make your code wrong. But is a signal of a bad practice