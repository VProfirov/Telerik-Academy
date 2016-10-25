/*Problem 16.	Decimal to Hexadecimal Number
Using loops write a program that converts an integer number to its hexadecimal representation. 
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
 * Examples:
 decimal	    hexadecimal
254	            FE
6883	        1AE3
338583669684	4ED528CBB4

 */
namespace DecimalToHexadecimalNumber
{
    using System;
    using System.Globalization;
    class DecimalToHexadecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter your decimal number: ");
            long dec = long.Parse(Console.ReadLine());

            string hexaStr = dec.ToString("X");

            //long hexa = long.Parse(hexaStr, NumberStyles.HexNumber);

            Console.WriteLine(hexaStr);
        }
    }
}
