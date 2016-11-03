/*Problem 15.	Hexadecimal to Decimal Number
Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 
 * Examples:
hexadecimal	    decimal
FE	            254
1AE3	        6883
4ED528CBB4	    338583669684

 */
namespace HexadecimalToDecimalNumber
{
    using System;
    using System.Globalization;

    class HexadecimalToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter you hexadecimal value: ");
            string hexa = Console.ReadLine();
            
            long dec = long.Parse(hexa, NumberStyles.HexNumber);

            Console.WriteLine(dec);
        }
    }
}
