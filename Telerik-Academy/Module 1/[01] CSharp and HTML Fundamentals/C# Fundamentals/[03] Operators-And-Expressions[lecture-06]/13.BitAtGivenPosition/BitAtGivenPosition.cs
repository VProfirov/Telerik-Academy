/*Problem 13.	Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
in given integer number n has value of 1.
* Examples:
 
 n	    binary representation of n	    p	bit @ p == 1
5	    00000000 00000101	            2	true
0	    00000000 00000000	            9	false
15	    00000000 00001111	            1	true
5343	00010100 11011111	            7	true
62241	11110011 00100001	            11	false

*/

namespace BitAtGivenPosition
{
    using System;

    class BitAtGivenPosition
    {
        static void Main()
        {
            int position;
            int number;
            Console.Write("Please enter number for bit extraction: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Please enter position for bit extraction: ");
            position = int.Parse(Console.ReadLine());
            //uint change = n >> p;
            //bool bit = (change == 1);


            //Moving to the bit position (counting from 0)
            number = number >> position;

            int mask = 1;
            //Checking the bit expression
            int maskAndNumber = number & mask;

            if (maskAndNumber == 1)
            {
                Console.WriteLine(true);
                Console.WriteLine("The bit on position {0} is 1",position);
            }
            else
            {
                Console.WriteLine(false);
                Console.WriteLine("The bit on position {0} is 0",position);
            }
            Console.WriteLine();            
        }
    }
}

// NOTES : ANOTHER SOLUTION

/*
            Console.Write("Please enter positive integer number  : ");

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please enter a position to be checked: ");

            int position = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //int position = 4; // Test
            //int number = 1567; // Test

            int bitType = 1;
            bool isGivenBit = false;
            //Moving at postion and preparing a "passive" check
            int newNumber = (number >> position) & 1;
            //Active check of the bite
            if (newNumber == bitType)
            {
                isGivenBit = true;
            }
            Console.WriteLine("The bit on position {0} is {1} : {2}", position, bitType, isGivenBit);
 
 
 */