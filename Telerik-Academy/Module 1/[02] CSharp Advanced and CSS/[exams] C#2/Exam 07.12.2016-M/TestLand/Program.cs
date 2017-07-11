using System;

namespace TestLand
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;

            var h = Convert.ToString(n, 16).ToUpper();

            Console.WriteLine(h);
        }
    }
}