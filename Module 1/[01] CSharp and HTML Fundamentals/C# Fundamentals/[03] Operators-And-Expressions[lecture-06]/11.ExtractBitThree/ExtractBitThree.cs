/*Problem 11.	Bitwise: Extract Bit #3
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.
 * Examples:
 
n	    binary representation	    bit #3
5	    00000000 00000101	        0
0	    00000000 00000000	        0
15	    00000000 00001111	        1
5343	00010100 11011111	        1
62241	11110011 00100001	        0

*/

namespace ExtractBitThree
{
    using System;

    class ExtractBitThree
    {
        static void Main()
        {
            int position = 3;
            uint number;

            Console.Write("Please enter number for bit extraction: ");
            number = uint.Parse(Console.ReadLine());

            uint numberRightPosition = number >> position;
            uint bit = numberRightPosition & 1;

            Console.WriteLine("Third bit of the number has value: " + bit);    

        }
    }
}

// NOTES : Another solution

/*
            Console.Write("Please enter a number to be checked : ");

            int number = int.Parse(Console.ReadLine());
            
            //int number = 9; //Test number 1001
            //int number = 7; //Test number  111

            //Moving to the 3th bit (counting from 0)
            number = number >> 3;

 * //// INFO - IMPORTANT
 *  mask = 1; ->       0000 0001 or enough zeros infront to make the comparison, so :
 *  
 *  number = 5343 -> 00010100 11011111 moved to N-th position (number >> N-th position) - > 00010100 11011 (111) -> 00010100 11011
 *  
 *  NB ! BUT IF COMPARED TO - > 1 -> it will not matter, because 1 is  00000000 00001 so everything compared to 0 with the operand ' & ' will be 0 with the exception of the last symbol which is 1, so
 *  -> Conclusion -> the only real comparison will be with the first  (right to left) digit / bit which is 1 and it will compare like this :  ------- ------'digit to compare'
 *                                                                                                                                                                  &
 *                                                                                                                                                                  1
 *                                                                                                                                           And if 'digit to compare'  is 1 -> 1 & 1 = 1 
 *                                                                                                                                                                      is 0 -> 0 & 1 = 0
 *  
 * 
            int mask = 1;
            //Checking the bit expression
            int maskAndNumber = number & mask;

            if (maskAndNumber == 1)
            {
                Console.WriteLine("The bit on position 3 is 1");
            }
            else
            {
                Console.WriteLine("The bit on position 3 is 0");
            }
            Console.WriteLine();
 */