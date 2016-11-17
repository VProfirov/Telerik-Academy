/*You are given an array of strings.
 * Write a method that sorts the array by the length of its elements
 * (the number of characters composing them).
*/



using System;
using System.Linq;

public class StringLenSort
{
    public static void Main()
    {
        string[] unsortedStrings = { "a", "aaaaa", "aaaawasdawd", "a", "12355asdf", "wdasdwe" };

        //  Linq !
        var sortedArray = unsortedStrings.OrderBy(uStrings => uStrings.Length);
        foreach (var item in sortedArray)
        {
            Console.WriteLine(item);
        }
    }
}
