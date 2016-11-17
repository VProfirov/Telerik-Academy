﻿/* Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
*   B)   {1,8,9,13}   
*        {2,7,10,14}  
*        {3,6,11,15}  
*        {4,5,12,16}  
*/



using System;

public class MatrixTwo
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
        int counter = 1;
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(1) - 1; row > -1; row--)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
        }

        PrintMatrix(matrix);
    }
}
