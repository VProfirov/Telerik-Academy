using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var numLines = int.Parse(Console.ReadLine());
            var result = new string[numLines];

            for (int l = 0; l < numLines; l++)
            {
                var num = int.Parse(Console.ReadLine());

                var arrDig = new int[4];
                arrDig[3] = num % 10;
                arrDig[2] = (num / 10) % 10;
                arrDig[1] = (num / 100) % 10;
                arrDig[0] = (num / 1000) % 10;

                var even = 0;
                var odd = 0;
                for (int i = 0; i < arrDig.Length; i++)
                {
                    if (arrDig[i] % 2 == 0)
                    {
                        even += arrDig[i];
                    }
                    else
                    {
                        odd += arrDig[i];
                    }
                }

                if (even > odd)
                {
                    ////Console.WriteLine("left");
                    result[l] = "left";
                }
                else if (odd > even)
                {
                    ////Console.WriteLine("right");
                    result[l] = "right";

                }
                else
                {
                    ////Console.WriteLine("straight");
                    result[l] = "straight";
                }
            }

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
