/*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
* C)   {7,11,14,16}
*      {4,8,12,15} 
*      {2,5,9,13}  
*      {1,3,6,10}  
*/




using System;

public class MatrixThree
{
    public static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int indexter1stHalf = 1;
        int indexter2ndHalf = size * size;
        int up = 0;
        for (int row = matrix.GetLength(0) - 1; row > -1; row--)
        {
            //start to end
            int currentRow = row; // end row
            int currentCol = 0;

            //positioning statements - start of diagonal
            matrix[currentRow, currentCol] = indexter1stHalf;
            indexter1stHalf++;
            while (true) // diagonal
            {
                #region DownwardDiagonal conitunation
                currentRow = currentRow + 1;
                currentCol = currentCol + 1;
                #endregion
                if (currentCol < 0 || currentRow < 0 || currentCol > size - 1 || currentRow > size - 1) //boundry check 
                // TODO: Re-Define - Dynamic programming (we can compute the possible boundry conditions to reduce computation) 
                // TODO : currentCol > size - 1 || currentRow > size - 1
                {
                    break;
                }

                matrix[currentRow, currentCol] = indexter1stHalf;
                indexter1stHalf++;
            }
            //end to start
            currentRow = up; // start row
            currentCol = size - 1;
            if (currentCol > 0)
            {
                matrix[currentRow, currentCol] = indexter2ndHalf;
                indexter2ndHalf--;
                while (true)
                {
                    currentRow = currentRow - 1;
                    currentCol = currentCol - 1;
                    if (currentCol < 0 || currentRow < 0 || currentCol > size - 1 || currentRow > size - 1) 
                        //TODO: writer out of boundry condition: currentCol > size - 1 || currentRow > size - 1 
                    {
                        break;
                    }

                    matrix[currentRow, currentCol] = indexter2ndHalf;
                    indexter2ndHalf--;
                }
            }
            up++;
        }
        PrintMatrix(matrix);
    }
}
