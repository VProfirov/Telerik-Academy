﻿/* Write a program to check if in a given 
 * expression the brackets are put correctly.
 * 
 * Example of correct expression: ((a+b)/5-d).
 * 
 * Example of incorrect expression: )(a+b)).
 */

// Stack

using System;
using System.Collections.Generic;

public class BracketCheckerWithStack
{
    public static void Main()
    {
        string input = Console.ReadLine();

        Stack<string> brackets = new Stack<string>();   // Stack 
        bool areCorrect = true;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                brackets.Push("(");
            }
            else if (input[i] == ')')
            {
                if (brackets.Count == 0)
                {
                    areCorrect = false;
                    break;
                }
                else
                {
                    brackets.Pop();
                }
            }
        }

        if (brackets.Count != 0)
        {
            areCorrect = false;
        }

        Console.WriteLine("The brackets are correctly put: {0}", areCorrect);
    }
}
