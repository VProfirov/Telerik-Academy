/*
Problem 9. Print a Sequence

Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
*/

namespace PrintSequence
{
    using System;

    class PrintSequence
    {
        static void Main()
        {
            int start = 2;
            int end = start + 10;

            for (int i = start; i < end; i++)
            {
                // % - provides devision of i by 2 but the result is ONLY the remainder
                // example : 4 % 2 = 2 (0 remainder) --> 5 % 2 = 2 ( and 1 as a remainder)
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ", i);
                }
                else
                {
                    #region LastSymbolFix
                    // To avoid the print of the last ','
                    if (i == 11)
                    {
                        Console.Write("{0}", i * (-1));
                        break;
                    }

                    #endregion

                    // Multiplying by negative one (-1) to fallow the Problem's positive, negative, positive sequence
                    Console.Write("{0}, ", i * (-1));
                }
            }
            Console.WriteLine();
        }
    }
}
// INFO : C# operator % - http://msdn.microsoft.com/en-us/library/0w4e0fzs(v=vs.90).aspx
// INFO : The Symbol # and the tag name "region" (#region) with #endregion signifies named portion of code (that can be collapsed if needed)
#region CleanerSolutionExample

/*
        int start = 2;
        int end = start + 10;

        List<int> list = new List<int>(capacity:end);

        for (int i = start; i < end; i++)
        {
            if (i%2==0)
            {
                list.Add(i);
            }
            else
            {
                list.Add(-1 * i);
            }
        }
        Console.WriteLine(string.Join(", ",list));
 */

#endregion