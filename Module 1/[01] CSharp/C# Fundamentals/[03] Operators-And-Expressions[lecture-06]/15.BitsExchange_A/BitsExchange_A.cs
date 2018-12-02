/*Problem 15.	* Bits Exchange
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 
 * Examples:
 
 n	        binary representation of n	                binary result	                           result
1140867093	01000[100] 00000000 01000000 00[010]101 	01000[010] 00000000 01000000 00[100]101 	1107312677
255406592	00001[111] 00111001 00110010 00[000]000 	00001[000] 00111001 00110010 00[111]000 	137966136
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

            // #region - #endregion is used to group content and name it, so it can be better visualized (usually not used withing code element - the Main())), but here is used for educational purpose. It is functions like a comment that way
            #region AtStartVisualistion
            // .ToString(number,desired numeric system) [binary,octal,decimal,hexadecimal] in STRING *representation
            // .Pad([where to placethe symbols to reach the count of symbols](count of symbol,'char symbol')
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            #endregion

            
             // To sumup, last index[31], total count[32] => 31 + 1[index 0]
            int fakeBitOneMove = 3;
            int fakeBitTwoMove = 24;

            for (int i = 0; i < 3; i++)
            {
           
                long maskOne = (number & (1 << fakeBitOneMove)) >> fakeBitOneMove;

                // (takes the bit from the number (sets bit to position)) returns to start with the bit
                long maskTwo = (number & (1 << fakeBitTwoMove)) >> fakeBitTwoMove;

                // CHANGE SECTION
                // Swap First part of Two :
                // Using mask ONE, to change fakeBit*Two*
                if (maskOne == 0)
                {
                    number = number & (~(1 << fakeBitTwoMove));
                }
                else if (maskOne == 1)
                {
                    number = number | (1 << fakeBitTwoMove);
                }

                // Swap Second part of Two
                // Using mask TWO
                if (maskTwo == 0)
                {
                    number = number & (~(1 << fakeBitOneMove));
                }
                else if (maskTwo == 1)
                {
                    // The if part is optional here, it is used to clarification, because it can't be any different then the opposite of 2 cases (1 or 0)
                    number = number | (1 << fakeBitOneMove);
                }

                // starting from 3 to 5, change +=1 untill gets to 5 => performing all the 3 exchanges
                fakeBitOneMove++; 

                // starting 24 to 26
                fakeBitTwoMove++;
            }

            // Result visualization
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(number);

            // NOTE! Ask for processing elements's indexes and  arrays's dimensions, VS bitwise *pseudo* indexing of bits
        }
    }
}
