using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricies
{
    class Print
    {
        public static void PrintMatrix(int[,] matrix, MatrixType type)
        {
            Console.WriteLine(type +"\n");

            int counter = 0;
            foreach (var num in matrix)
            {
                //size fix
                Console.Write("{0,-4}",num);
                counter++;
                if (counter > matrix.GetLength(0) - 1)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
            Console.WriteLine("\n" + new string(' ', matrix.GetLength(0) * 5));
        }
    }
}
