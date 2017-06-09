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
            int position = 0;
            int check = 0;
            while (true)
            {
                check = int.Parse(pattern[position].ToString());
                if (check == 0)
                {
                    Console.WriteLine("Too drunk to go on after {0}!", position);
                    break;
                }
                else if (check % 2 == 0)
                {
                    position += check;
                }
                else
                {
                    position -= check;
                }

                if (position < 0 || position >= pattern.Length)
                {
                    Console.WriteLine("Fell off the dancefloor at {0}!", position);
                    break;
                }

                if (pattern[position] == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", position);
                    break;
                }
            }

        }
    }
}
