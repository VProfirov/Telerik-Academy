using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            int[] paperSizes = new int[11];
            paperSizes[0] = 1; ////paper size A11
            for (int i = 1; i < paperSizes.Length; i++)
            {
                paperSizes[i] = paperSizes[i - 1] * 2;
            }

            Array.Reverse(paperSizes);
            //// paper types
            string[] arrPaper = new string[11];
            for (int i = 0; i < arrPaper.Length; i++)
            {
                arrPaper[i] = "A" + i;
            }

           /* foreach (var paper in arrPaper)
            {
                Console.WriteLine(paper);
            }*/
            ////paper to use
            for (int i = 0; i < paperSizes.Length; i++)
            {
                if (num == 0)
                {
                    break;
                }

                if (paperSizes[i] <= num)
                {
                    num -= paperSizes[i];
                    paperSizes[i] = 0;
                }
            }
        /*    Console.WriteLine(num);

            var count = 1;
           foreach (var size in paperSizes)
           {
               Console.WriteLine(size);
               Console.WriteLine("-------  " + count++);
           }*/

            for (int i = 0; i < paperSizes.Length; i++)
            {
                if (paperSizes[i] == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(arrPaper[i]);
                }
            }
        }
    }
}
