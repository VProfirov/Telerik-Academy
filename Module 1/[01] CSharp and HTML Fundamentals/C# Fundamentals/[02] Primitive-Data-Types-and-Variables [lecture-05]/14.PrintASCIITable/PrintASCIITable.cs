/*
Problem 14.* Print the ASCII Table

Find online more information about ASCII (American Standard Code for Information Interchange) 
and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

Note: You may need to use for-loops (learn in Internet how).
*/

namespace PrintASCIITable
{
    using System;
    using System.Text;

    class PrintASCIITable
    {
        static void Main()
        {
            //encoding for the chars
            Console.OutputEncoding = Encoding.Unicode;
            //loop to go from 0 to 255 one after the other
            for (int i = 0; i <= 255; i++)
            {
                char symbol = (char)i;
                Console.WriteLine("ASCII symbol {0} and its number {1}", symbol, i);
            }
        }
    }
}