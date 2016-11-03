/*
Problem 4. Unicode Character

Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *
*/

namespace UnicodeSymbol
{
    using System;

    class UnicodeSymbol
    {
        static void Main()
        {
            char symbol = '\u002A';

            string representation = @"\u002A";
            Console.WriteLine("The Unicode code of 42, with hexadecimal representation of {0} is {1}",
                representation, symbol);
        }
    }
}