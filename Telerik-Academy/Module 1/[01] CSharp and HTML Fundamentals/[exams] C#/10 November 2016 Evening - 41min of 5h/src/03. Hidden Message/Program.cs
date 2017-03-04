using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03.Hidden_Message
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var check = Console.ReadLine();
            var sb = new StringBuilder();


            if (check != "end")
            {
                do
                {
                    var index = int.Parse(check);
                    var skip = int.Parse(Console.ReadLine());
                    var pattern = Console.ReadLine();
                    check = Console.ReadLine();

                    if (index < 0) { index = pattern.Length + index; }
                    if (skip < 0)
                    {
                        for (int i = index; i >= 0; i += skip)
                        {
                            sb.Append(pattern[i]);
                        }
                    }
                    else
                    {
                        for (int i = index; i < pattern.Length; i += skip)
                        {
                            sb.Append(pattern[i]);
                        }

                    }



                } while (check != "end");
            }
            Console.WriteLine(sb.ToString());

        }
    }
}
