using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int t =  n % 10;
            int s = (n / 10) % 10;
            int f = (n / 100) % 10;

            double result = 0;

            if (t == 0)
            {
                result = s * f;
            }
            if (t > 0 && t <= 5) //??? drunnk ??? 3th between 0 and 5 inclusive ???
            {
                result = (s * f) / (double) t;
            }
            if (t > 5)
            {
               result = (s+f)*t;
            }

            Console.WriteLine("{0:F2}", result);
        }
    }
}
