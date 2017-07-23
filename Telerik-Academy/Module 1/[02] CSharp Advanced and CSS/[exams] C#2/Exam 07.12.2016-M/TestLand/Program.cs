using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(PrintN());
    }

    public static void PrintFinally()
    {
        Console.WriteLine("Finally");
    }

    public static string PrintN()
    {
        try
        {
            var a = 5;
            while (a-- > 0)
            {
                Console.WriteLine(a);
            }
            return "DONE";
        }
        finally
        {
            PrintFinally();
        }
    }
}