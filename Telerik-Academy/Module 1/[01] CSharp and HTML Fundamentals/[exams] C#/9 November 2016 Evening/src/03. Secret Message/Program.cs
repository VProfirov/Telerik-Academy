using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03.Secret_Message
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var isOddLine = true;
            // s/e => -100 >=< 100
            // s !> e

            //pattern.len => 1 >=< 100             &         .Contains([',', '.', '!', ' ']) => NotNeeded

            //0th compute
            var check = Console.ReadLine();
            if (check != "end")
           {
                int s = int.Parse(check);
                int e = int.Parse(Console.ReadLine());
                var pattern = Console.ReadLine();

                sb.Append(ComputedString(s, e, pattern, isOddLine));
                while (true)
                {
                    check = Console.ReadLine();
                    if (check == "end")
                    {
                        break;
                    }
                    s = int.Parse(check);
                    e = int.Parse(Console.ReadLine());
                    pattern = Console.ReadLine();
                    isOddLine = !isOddLine;

                    sb.Append(ComputedString(s, e, pattern, isOddLine));
                }
            }
            Console.WriteLine(sb.ToString());
        }

        public static string ComputedString(int s, int e, string pattern, bool isOddLine)
        {
            var reverseDirection = false;
            if (s < 0) { s = pattern.Length + s; }
            if (e < 0) { e = pattern.Length + e; }
            if (s > e) { reverseDirection = true; }

            if (isOddLine)
            {
                int jump = 3;
                if (reverseDirection) { return ReversedDirection(s, e, pattern, jump); }
                else { return NormalDirection(s, e, pattern, jump); }
            }
            else
            {
                int jump = 4;
                if (reverseDirection) { return ReversedDirection(s, e, pattern, jump); }
                else { return NormalDirection(s, e, pattern, jump); }
            }
        }
        public static string NormalDirection(int s, int e, string pattern, int jump)
        {
            var sb = new StringBuilder();
            for (int i = s; i <= e; i += jump)
            {
                sb.Append((char) pattern[i]);
            }
            return sb.ToString();
        }
        public static string ReversedDirection(int s, int e, string pattern, int jump)
        {
            var sb = new StringBuilder();
            for (int i = e; i >= e; i -= jump)
            {
                sb.Append((char) pattern[i]);
            }
            return sb.ToString();
        }
    }
}
