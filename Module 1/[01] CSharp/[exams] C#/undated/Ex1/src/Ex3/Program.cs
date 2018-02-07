using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var startStr = Console.ReadLine();
            var hiddenMsg = "";

            while (startStr != "end")
            {
                int ind = int.Parse(startStr);
                int step = int.Parse(Console.ReadLine());

                string line = Console.ReadLine();

                if (ind < 0)
                {
                    ind += line.Length;
                }

                for (; ind < line.Length && ind >= 0; ind+= step)
                {
                    hiddenMsg += line[ind];
                }

                startStr = Console.ReadLine();

            }

            Console.WriteLine(hiddenMsg);

        }
    }
}
