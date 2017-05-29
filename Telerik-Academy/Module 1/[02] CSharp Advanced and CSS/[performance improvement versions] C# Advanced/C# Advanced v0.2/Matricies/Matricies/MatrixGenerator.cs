using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricies
{
    using System.Diagnostics;

    class MatrixGenerator
    {
        private int size;
        private int[,] matrix;

        public MatrixGenerator(int size)
        {
            this.size = size;
            this.matrix = new int[size,size];
        }

        public int[,] GetMatrix(MatrixType type)
        {
            switch (type)
            {
                case MatrixType.Type_A:
                    this.GenerateMatrix_A();
                    break;
                case MatrixType.Type_B:
                    this.GenerateMatrix_B();
                    break;
                case MatrixType.Type_C:
                    this.GenerateMatrix_C();
                    break;
                case MatrixType.Type_D:
                    this.GenerateMatrix_D();
                    break;
                default:
                    break;
            }

            return this.matrix;
        }

        private void GenerateMatrix_A()
        {
            int number = 1;
            for (int col = 0; col < this.size; col++)
            {
                for (int row = 0; row < this.size; row++)
                {
                    this.matrix[row, col] = number++;
                }
            }
        }

        private void GenerateMatrix_B()
        {
            int number = 1;
            bool change = false;
            for (int col = 0; col < this.size; col++)
            {
                if (change)
                {
                    for (int row = this.size - 1; row >= 0; row--)
                    {
                        this.matrix[row, col] = number++;
                    }
                    change = false;
                }
                else
                {
                    for (int row = 0; row < this.size; row++)
                    {
                        this.matrix[row, col] = number++;
                    }
                    change = true;
                }
            }
        }

        private void GenerateMatrix_C()
        {
            int number = 1;
            int pointerRow;

            for (int row = this.size - 1; row >= 0; row--)
            {
                pointerRow = row;
                for (int col = 0; col < this.size - row; col++)
                {
                    this.matrix[pointerRow++, col] = number++;
                }
            }

            number = this.size * this.size;

            for (int row = 0; row < this.size - 1; row++)
            {
                pointerRow = row;
                for (int col = this.size - 1; pointerRow >= 0; col--)
                {
                    this.matrix[pointerRow--, col] = number--;
                }
            }
        }

        private void GenerateMatrix_D()
        {
            this.matrix = new int[this.size, this.size];// ?
            int number = 1;
            int[] rowDRUL = { 1, 0, -1, 0 };
            int[] colDRUL = { 0, 1, 0, -1 };
            int direction = 0;
            int row = 0;
            int col = 0;
            int nextRowChecker;
            int nextColChecker;

            int lastNumber = this.size * this.size;
            int patternBoundSize = this.matrix.Rank * this.matrix.Rank;
            while (number<=lastNumber)
            {
                // if the matrix has atleast minimal condition
                this.matrix[row, col] = number++;

                nextRowChecker = row + rowDRUL[direction];
                nextColChecker = col + colDRUL[direction];
                ////if out of bound
                if ((nextRowChecker >= this.size || nextRowChecker < 0)||
                    (nextColChecker >= this.size || nextColChecker < 0)||
                    (this.matrix[nextRowChecker, nextColChecker] != 0)) //<- /?/
                {
                    direction = (direction + 1) % patternBoundSize;
                }

                row += rowDRUL[direction]; // 0 + 0 + -1 <- /?/
                col += colDRUL[direction];
            }
        }
    }
}
