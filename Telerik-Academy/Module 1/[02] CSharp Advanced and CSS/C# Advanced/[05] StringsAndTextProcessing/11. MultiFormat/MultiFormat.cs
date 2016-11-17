/*Write a program that reads a number and prints it as 
 * 
 * a decimal number,
 * hexadecimal number,
 * percentage and
 * in scientific notation.
 * 
* Format the output aligned right in 15 symbols.
*/


using System;

public class MultiFormat
{
    public static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("{0,15}", input);
        Console.WriteLine("{0,15:X}", input);
        Console.WriteLine("{0,15:P}", input);
        Console.WriteLine("{0,15:E5}", input);
    }
}
