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
            char[] ch = new char[1];
            char c = ch[0];
            Console.WriteLine((int)c);
            Console.WriteLine((int)ch[0]);
            Console.WriteLine($"Def new char[1]: {default(char[])}");
            Console.WriteLine($"Default char: {default(char)}");

            Console.WriteLine($"Default TimeSpan: {default(TimeSpan)}");
            Console.WriteLine("{0}",new string('_',50));
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
