/*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
 * 
 * A)   {1,5,9,13}   
 *      {2,6,10,14}  
 *      {3,7,11,15}  
 *      {4,8,12,16}  
 */                                         

using System;

public class Matrix
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
        int n = int.Parse(Console.ReadLine());
        int[,] myMatrix = new int[n, n];
        int counter = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                myMatrix[row, col] = counter;
                counter++;
                //// matrix[i, j] = i + 1 + size*j;  
            }
        }

        PrintMatrix(myMatrix);
    }
}
