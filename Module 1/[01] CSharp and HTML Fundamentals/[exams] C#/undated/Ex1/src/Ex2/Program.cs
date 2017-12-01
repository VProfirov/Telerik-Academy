using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pattern = Console.ReadLine();

            var ind = 0;
            var msg = "Fell off the dancefloor at {0}!";
            while (ind >= 0 && ind < pattern.Length)
            {
                char ch = pattern[ind];
                int num = ch - '0';

                if (ch == '^')
                {
                    msg = "Jump, Jump, DJ Tomekk kommt at {0}!";
                    break;
                }
                else if ((ch- '0') == 0)
                {
                    msg = "Too drunk to go on after {0}!";
                    break;
                }
                else if ((ch - '0') % 2 == 0)
                {
                    ind += num;
                }
                else if ((ch - '0') % 2 == 1)
                {
                    ind -= num;
                }
            }

            Console.WriteLine(msg,ind);
        }
    }
}
