/*Problem 14.	Modify a Bit at Given Position
We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. 
 * Examples:

 n	binary representation of n	p	v	binary result	result
5	    00000000 00000101	2	0	00000000 00000001	1
0	    00000000 00000000	9	1	00000010 00000000	512
15	    00000000 00001111	1	1	00000000 00001111	15
5343	00010100 11011111	7	0	00010100 01011111	5215
62241	11110011 00100001	11	0	11110011 00100001	62241

 */

namespace ModifyBitAtPosition
{
    using System;

    class ModifyBitAtPosition
    {
        static void Main()
        {
            int number;
            int position;
            int value;
            int mask;
            int result;

            Console.Write("Please enter number: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Your number in binary format is " + (Convert.ToString(number, 2).PadLeft(16, '0')));

            Console.Write("Please enter position: ");
            position = int.Parse(Console.ReadLine());

            Console.Write("Please enter value (1 or 0): ");
            value = int.Parse(Console.ReadLine());
            
            if (value == 0)
            {
                // 1 => 100000 (0's position's count)
                // then "~" revert it, to 011111
                mask = ~(1 << position);

                // use  & 011111   
                /*
                 => case: 
                 number(100100)
                      & 011111
                      _________
                        0(modified 1 to 0) => becomes 0 in any case possible ( 1 or 0 )
                        *0*1....(the rest is the same)
                      _________
                        000100
                 */
                result = number & mask;
            }
            else
            {
                // 1 => 100000, NB! no reversion
                mask = value << position;

                // using "|" in any case ( 1 or 0 ) it will become 1
                result = number | mask;
            }

            Console.WriteLine("Your new number in binary format is " + (Convert.ToString(result, 2).PadLeft(16, '0')));
            Console.WriteLine("Your new number is {0}", result);
        }
    }
}
