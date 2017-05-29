using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricies
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            MatrixGenerator matrix = new MatrixGenerator(size);

            Print.PrintMatrix(matrix.GetMatrix(MatrixType.Type_A),MatrixType.Type_A);
            Print.PrintMatrix(matrix.GetMatrix(MatrixType.Type_C), MatrixType.Type_C);
            Print.PrintMatrix(matrix.GetMatrix(MatrixType.Type_B), MatrixType.Type_B);
            Print.PrintMatrix(matrix.GetMatrix(MatrixType.Type_D), MatrixType.Type_D);
        }
    }
}
