/*
Problem 16.* Print Long Sequence

Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
You might need to learn how to use loops in C# (search in Internet).
*/

namespace PrintLongSequence
{
    using System;

    class PrintLongSequence
    {
        static void Main()
        {
            // Sequence loop -> (look at INFO* at the end)
            for (int i = 2; i < 1002; i++)
            {
                // Conditional statement using if-else (to determine the "+" and the "-" symbol)
                // -> (look at INFO* at the end)
                if (i % 2 == 0)
                {
                    Console.Write(" {0},", i);
                    // Formating the printed output on the console using if-else
                    if (i % 10 == 0)
                    {
                        Console.Write("\r\n");
                    }
                }
                else
                {
                    Console.Write(" {0},", i * (-1));
                }
            }
            Console.WriteLine();

        }
    }
}
//INFO : Loop -> http://msdn.microsoft.com/en-us/library/ezk76t25.aspx
//       if-else -> http://msdn.microsoft.com/en-us/library/5011f09h.aspx

            #region PrintMethodsExamples
/*            //direct
            Console.WriteLine("string value");
            //using placeholders {0} - where inside {} is the number of the argument to use in that place
            string str = "value";
            Console.WriteLine("string {0}",str);
            //computed parameter (like in JS) - where the $ is used to signify up-comming elements for evaluation and computing
            Console.WriteLine($"string {str}");
            Console.WriteLine($"string {str + " " +(1+2)}");
*/
            #endregion
