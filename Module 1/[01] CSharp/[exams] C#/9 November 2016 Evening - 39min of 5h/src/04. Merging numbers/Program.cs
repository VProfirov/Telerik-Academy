using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace _04.Merging_numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var arrN = new int[length];
            var arrS = new string[length];
            for (int i = 0; i < length; i++)
            {
                arrS[i] = Console.ReadLine();
                arrN[i] = int.Parse(arrS[i]);
            }

            var sb_line1 = new StringBuilder();
            var sb_line2 = new StringBuilder();
            for (int i = 0; i < length - 1; i++)
            {
                sb_line1.AppendFormat("{0}{1} ", (char) arrS[i][arrS[i].Length - 1], (char) arrS[i + 1][0]);
                sb_line2.AppendFormat("{0} ", arrN[i] + arrN[i + 1]);
            }
            var line1 = sb_line1.ToString().Trim();
            var line2 = sb_line2.ToString().Trim();

            Console.WriteLine(line1);
            Console.WriteLine(line2);
        }
    }
}

