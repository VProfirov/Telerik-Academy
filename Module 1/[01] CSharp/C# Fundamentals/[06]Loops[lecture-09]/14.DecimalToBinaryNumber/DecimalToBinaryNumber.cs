/*Problem 14.	Decimal to Binary Number
Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 
* Examples :
 decimal	binary
0	        0
3	        11
43691	    1010101010101011
236476736	1110000110000101100101000000

 */
namespace DecimalToBinaryNumber
{
    using System;
    using System.Linq;
    using System.Text;

    class DecimalToBinaryNumber
    {
        static void Main()
        {
            Console.Write("Enter your decimal number: ");
            long longInt = long.Parse(Console.ReadLine());

            Console.WriteLine(DecimalToStringWithStringBuilder(longInt));
            Console.WriteLine(DecimalToBinaryWithConcat(longInt));
        }

        static string DecimalToStringWithStringBuilder(long decimalNumber)
        {
            var binary = new StringBuilder();
            long rest;

            while (decimalNumber > 0)
            {
                rest = decimalNumber % 2;
                decimalNumber /= 2;
                binary.Append(rest);
            }

            //TODO: Something better?
            return binary.ToString().Reverse().ToString();
        }

        static string DecimalToBinaryWithConcat(long decimalNumber)
        {
            long rest;
            string binary = string.Empty;

            while (decimalNumber > 0)
            {
                rest = decimalNumber % 2;
                decimalNumber /= 2;
                binary = rest.ToString() + binary;
            }
            return binary;
        }
    }
}
