using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02.Jump__Jump
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
                var number = int.Parse(pattern[i].ToString());
                if (number % 2 == 0 && number != 0)
                {
                    i += number;
                }
                else if (number % 2 != 0)
                {
                    i -= number;
                }
                else
                {
                    atParty = false;
                    Console.WriteLine("Too drunk to go on after {0}!", i);
                    break;
                }
                

                if (i < 0 || i > pattern.Length - 1)
                {
                    atParty = false;
                    Console.WriteLine("Fell off the dancefloor at {0}!", i);
                    break;
                }
            }

            if (atParty)
            {
                Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
            }
        }
    }
}
