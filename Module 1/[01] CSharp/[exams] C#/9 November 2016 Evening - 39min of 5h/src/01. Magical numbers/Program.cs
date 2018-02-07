using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01.Magical_numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            int t = (int)(n) % 10;
            int s = (int)(n / 10) % 10;
            int f = (int)(n / 100) % 10;

            if (s % 2 == 0)
            {
                Console.WriteLine("{0:F2}",(f + s) * t);
            }
            else
            {
                Console.WriteLine("{0:F2}",(double)(f * s) / t);
            }
        }
    }
}
