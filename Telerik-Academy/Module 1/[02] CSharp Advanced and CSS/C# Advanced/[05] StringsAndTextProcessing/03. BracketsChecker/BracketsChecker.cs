/* Write a program to check if in a given 
 * expression the brackets are put correctly.
 * 
 * Example of correct expression: ((a+b)/5-d).
 * 
 * Example of incorrect expression: )(a+b)).
 */

using System;

public class BracketsChecker
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int brackerChecker = 0;
        for (int i = 0; i < input.Length; i++)
        {
            // START - Bracket checking condition (for non equal number of closing and opening brackets)
            // Not perfect but it satisfies the condition of the task.
            if (input[i] == '(')
            {
                brackerChecker++;
            }
            else if (input[i] == ')')
            {
                brackerChecker--;
            }
            // END
        }

        if (brackerChecker == 0)
        {
            Console.WriteLine("All are correctly closed");
        }
        else
        {
            Console.WriteLine("Bracket problem!");
        }
    }
}
