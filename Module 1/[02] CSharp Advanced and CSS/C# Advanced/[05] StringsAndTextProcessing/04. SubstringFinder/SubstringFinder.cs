/* Write a program that finds
 * 
 * how many times a substring 
 * is contained in a given text (perform case insensitive search).
 * 
 * Example: The target substring is "in". The text is as follows:
 * 
 * We are liv/in/g /in/ an yellow submar/in/e.
 * We don't have anyth/in/g else.
 * /In/side the submar/in/e is very tight.
 * So we are dr/in/k/in/g all the day.
 * We will move out of it /in/ 5 days.
 
 * The result is: 9.

 */

using System;

public class SubstringFinder
{
    public static void Main()
    {
        ////string test = "inmyinajin";
        ////Console.WriteLine(test.IndexOf("in"));
        ////Console.WriteLine(test.IndexOf("in",1,test.Length - 1));
        string input = Console.ReadLine();
        string searchSub = Console.ReadLine();
        int subStringCounter = 0;
        int startIndex = 0;
        bool noString = false;
        while (!noString)
        {
            if (input.IndexOf(searchSub, startIndex) != -1)
            {
                subStringCounter++;
                startIndex = input.IndexOf(searchSub, startIndex) + 1;
            }
            else
            {
                noString = true;
            }
        }

        Console.WriteLine(subStringCounter);
    }
}
