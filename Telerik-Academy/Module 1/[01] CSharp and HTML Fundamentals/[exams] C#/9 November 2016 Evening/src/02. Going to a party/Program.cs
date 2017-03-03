using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02.Going_to_a_party
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pattern = Console.ReadLine();

            var i = 0;
            var atParty = true;
            while (pattern[i] != '^')
            {
                if ((int) pattern[i] >= 'a' && (int) pattern[i] <= 'z')
                {
                    i += (int) pattern[i] - 'a' + 1;
                }
                else if ((int) pattern[i] >= 'A' && (int) pattern[i] <= 'Z')
                {
                    i -= (int) pattern[i] - 'A' + 1;

                }

                if (i < 0 || i > pattern.Length-1)
                {
                    atParty = false;
                    Console.WriteLine("Djor and Djano are lost at {0}!",i);
                    break;
                }
            }

            if (atParty)
            {
                Console.WriteLine("Djor and Djano are at the party at {0}!",i);
            }
        }
    }
}
