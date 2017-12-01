using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Mixing_numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var arrS = new string[N];
            var arrN = new int[N];

            var line1 = new StringBuilder();
            var line2 = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                arrS[i] = Console.ReadLine();
                arrN[i] = int.Parse(arrS[i]);
            }
            
            for (int i = 0; i < N-1; i++)
            {
                var p1 = (arrS[i][arrS[i].Length - 1]);
                var p2 = (arrS[i+1][0]);
                var n1 = int.Parse(p1.ToString());
                var n2 = int.Parse(p2.ToString());
                line1.AppendFormat("{0} ", n1 * n2);
                line2.AppendFormat("{0} ", Math.Abs(arrN[i] - arrN[i + 1]));
            }

            Console.WriteLine(line1.ToString());
            Console.WriteLine(line2.ToString());
        }
    }
}
