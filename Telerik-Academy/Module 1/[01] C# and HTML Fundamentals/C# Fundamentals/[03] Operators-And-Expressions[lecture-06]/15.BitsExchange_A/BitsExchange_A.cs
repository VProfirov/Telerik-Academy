/*Problem 15.	* Bits Exchange
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 
 * Examples:
 
 n	        binary representation of n	            binary result	                           result
1140867093	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
255406592	00001111 00111001 00110010 00000000 	00001000 00111001 00110010 00111000 	137966136
 * 
 * :D :D

*/
namespace BitsExchange_A
{
    using System;

    class BitsExchange_A
    {
        static void Main()
        {
            Console.Write("Enter your number: ");
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            int fakeBitOne = 3;
            int fakeBitTwo = 24;

            for (int i = 0; i < 3; i++)
            {
                long maskOne = (number & (1 << fakeBitOne)) >> fakeBitOne;
                long maskTwo = (number & (1 << fakeBitTwo)) >> fakeBitTwo;

                //mask one
                if (maskOne == 0)
                {
                    number = number & (~(1 << fakeBitTwo));
                }
                else if (maskOne == 1)
                {
                    number = number | (1 << fakeBitTwo);
                }

                //mask two
                if (maskTwo == 0)
                {
                    number = number & (~(1 << fakeBitOne));
                }
                else if (maskTwo == 1)
                {
                    number = number | (1 << fakeBitOne);
                }

                fakeBitOne++;
                fakeBitTwo++;
            }

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(number);
        }
    }
}