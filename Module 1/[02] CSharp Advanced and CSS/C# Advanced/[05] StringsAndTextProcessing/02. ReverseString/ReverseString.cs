/* Write a program that reads a string, 
 * reverses it and prints the result at the console.
 *
 * Example: "sample"  "elpmas".
 */

using System;

public class ReverseString
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(input);

        // use a reverse "for" cycle to read (access) and print it backwards

        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }

        Console.WriteLine();
    }
}
