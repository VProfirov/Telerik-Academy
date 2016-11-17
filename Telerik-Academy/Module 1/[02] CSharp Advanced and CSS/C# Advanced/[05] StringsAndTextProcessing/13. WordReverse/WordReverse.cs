/*Write a program that reverses the words in given sentence.
 * 
	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
 */


using System;

public class WordReverse
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();

        // end sign
        char endSign = input[input.Length - 1][input[input.Length - 1].Length - 1];
        input[input.Length - 1] = input[input.Length - 1].Remove(input[input.Length - 1].Length - 1, 1);
        Console.WriteLine(endSign);

        // main logic
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write("{0} ", input[i]);
        }

        Console.Write(endSign);
        Console.WriteLine();

        //  comma detection .... ->
    }
}
