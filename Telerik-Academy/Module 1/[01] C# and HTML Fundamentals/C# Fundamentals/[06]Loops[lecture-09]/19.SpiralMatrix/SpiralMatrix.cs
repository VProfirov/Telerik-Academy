/*Problem 19.	** Spiral Matrix
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below. 
Examples:
 n	    matrix
 4	    1  2  3  4
        12 13 14 5
        11 16 15 6
        10 9  8  7

 */
namespace SpiralMatrix
{
    using System;

    class SpiralMatrix
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            string direction = "right";
            int maxRotations = n * n;

            for (int i = 1; i <= maxRotations; i++)
            {
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && row < 0 || matrix[row, col] != 0)
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }

            // Display Matrix 

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,4}", matrix[r, c]);
                }
                Console.WriteLine();
            }


            // OR

            /*
             Console.WriteLine("Enter a Number:");
             int size = int.Parse(Console.ReadLine());
             int[,] matrix = new int[size, size];
             int start = 0;
             int end = size;
             int numbers = 1;
             while (end - start >= 1)
                {
                    for (int i = start; i < end; i++)
                    {
                        matrix[start, i] = numbers;
                        numbers++;
                    }
                    for (int p = start + 1; p < end; p++)
                    {
                        matrix[p, end - 1] = numbers;
                        numbers++;
                    }
                    for (int j = end - 2; j >= start; j--)
                    {
                        matrix[end - 1, j] = numbers;
                        numbers++;
                    }
                    for (int x = end - 2; x >= start + 1; x--)
                    {
                        matrix[x, start] = numbers;
                        numbers++;
                    }
                    start = start + 1;
                    end = end - 1;
                }
                // printing the matrix
                for (int counter = 0; counter < size; counter++)
                {
                    for (int counterTwo = 0; counterTwo < size; counterTwo++)
                    {
                        Console.Write(matrix[counter, counterTwo] + "\t");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
             */
        }
    }
}
