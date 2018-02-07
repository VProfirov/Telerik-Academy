/*Write a program that
 * 
 * reads a rectangular matrix of size N x M
 * and finds in it the square 3 x 3 that has maximal sum of its elements.
*/

using System;

public class MaxSumArea
{
    public static int MaxSum(int[,] matrix)
    {
        int bestSum = int.MinValue;
        for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 2; cols++)
            {
                // 3x3 checker 
                // * * * - -
                // * * * - -
                // * * * - -
                int currentSum = 0;
                for (int newRow = rows; newRow < rows + 3; newRow++)
                {
                    for (int newCol = cols; newCol < cols + 3; newCol++)
                    {
                        currentSum = currentSum + matrix[newRow, newCol];
                    }
                }

                // best sum check
                if (bestSum <= currentSum)
                {
                    bestSum = currentSum;
                }
            }
        }

        return bestSum;
    }

    public static void Main()
    {
        int[,] matrix = 
        {
           { 1, 1, 1, 1, 1 },
           { 1, 1, 1, 1, 1 },
           { 1, 1, 1, 1, 2 }
        };

        int bestSum = MaxSum(matrix);
        Console.WriteLine(bestSum);
    }
}
