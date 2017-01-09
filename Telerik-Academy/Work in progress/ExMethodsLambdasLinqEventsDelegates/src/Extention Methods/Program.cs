using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Extention_Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] strR =
                {
                    "Lorem ipsum dolor sit amet,", "consectetur adipiscing elit.",
                    "Vestibulum lobortis dolor eu vulputate interdum.",
                    "Morbi semper lorem quis condimentum aliquet.",
                    "Donec auctor ligula eget odio ornare, ac commodo orci malesuada."
                };

            string[] linqED = strR.Where(x => x.Length > 30).ToArray();
            
            foreach (var lin in linqED)
            {
                Console.WriteLine(lin);
            }
        }
    }
}
