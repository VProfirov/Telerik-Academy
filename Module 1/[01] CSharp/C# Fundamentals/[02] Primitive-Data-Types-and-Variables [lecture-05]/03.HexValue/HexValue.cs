/*
Problem 3. Variable in Hexadecimal Format

Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
Use Windows Calculator to find its hexadecimal representation.
Print the variable and ensure that the result is 254
*/

namespace HexValue
{
    using System;

    class HexValue
    {
        static void Main()
        {
            //int HexValue = 254;
            int hexVaulue = 0xFE;

            string representation = "0xFE";

            Console.WriteLine("The hexadecimal representation of {0} is {1}", hexVaulue, representation);
        }
    }
}