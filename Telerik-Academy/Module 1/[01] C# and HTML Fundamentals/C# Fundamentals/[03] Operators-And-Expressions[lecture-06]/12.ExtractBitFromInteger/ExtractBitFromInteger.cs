/*Problem 12.	Extract Bit from Integer
Write an expression that extracts from given integer n the value of given bit at index p.
 * Examples:

 * n	binary representation	p	bit @ p
5	    00000000 00000101	    2	1
0	    00000000 00000000	    9	0
15	    00000000 00001111	    1	1
5343	00010100 11011111	    7	1
62241	11110011 00100001	    11	0

 */

namespace ExtractBitFromInteger
{
    using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            int p;
            uint n;
            Console.Write("Please enter number for bit extraction: ");
            n = uint.Parse(Console.ReadLine());
            Console.Write("Please enter position for bit extraction: ");
            p = int.Parse(Console.ReadLine());
            uint nRightP = n >> p;
            uint bit = nRightP & 1;
            Console.WriteLine("Bit at position {1} has value: {0} ", bit, p);
        }
    }
}

// NOTES : Another solution

/*
            Console.Write("Please enter integer number  : ");

            int iNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please enter a position (bit number) to be checked: ");

            int bBitNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //int iNumber = 36; // Test
            //int bBitNumber = 4; // Test

            byte value = 1;
            //Moving at postion and preparing a "passive" check
            int newNumber = (iNumber >> bBitNumber) & 1;
            //Active check of the bite
            if (newNumber == 0)
            {
                value = 0;
            }
            else
            {
                value = 1;
            }
            Console.WriteLine("The value ot the {0} - th bit is {1}", bBitNumber, value);
  
 */