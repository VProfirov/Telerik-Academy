using System;
using System.Linq;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split('x').Select(int.Parse).ToArray(); // as int[] null error
            var matrix = new char[dimensions[0]][];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }
            var directions = Console.ReadLine().Split(',').Aggregate((previous,current) => previous + current).ToCharArray();
            var position = 0;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                if (matrix[0][i] == 'e')
                {
                    position = i;
                }
            }


            //denUtilityCheck(matrix);
            void denUtilityCheck(char[][] denMap)
            {
                for (int r = 0; r < denMap.Length; r++)
                {
                    for (int c = 0; c < denMap[r].Length; c++)
                    {
                        Console.Write(denMap[r][c]);
                    }
                    Console.WriteLine();
                }
            }

            var row = 0;
            var col = position;
            var snakeLength = 3;//starts with
            var move = 0;// %5 => snake -=1
            var output = $"Sneaky is going to be stuck in the den at [{row},{col}]";
            for (int i = 0; i < directions.Length; i++)
            {
                //change direction
                switch (directions[i])
                {
                    case 's': row += 1; break;
                    case 'w': row -= 1; break;
                    case 'a': col -= 1; break;
                    case 'd': col += 1; break;
                    default: throw new ArgumentException("wrong direction passed");
                }
                //make a move
                switch (matrix[row][col])
                {
                    case '-':break;
                    case '%':
                        output = $"Sneaky is going to hit a rock at [{row},{col}]";
                        break;
                    case '@':
                        snakeLength += 1;
                        matrix[row][col] = '.';//egg eaten
                        break;
                    case 'e':
                        output = $"Sneaky is going to get out with length {snakeLength}";
                        break;
                    default:
                        break;
                }
                move += 1;

                //take action /@#!@#$!
                if (snakeLength == 0)
                {
                    output = "Sneaky is going to starve at [R,C]";
                }
                if (row >= matrix.Length)
                {
                    output = $"Sneaky is going to be lost into the depths with length {snakeLength}";
                }
                if (col >= matrix[0].Length)//dimension confirmation check
                {
                    col %= matrix[0].Length;
                }
                if (move%5 ==0)//move's count %5 snake slim check
                {
                    snakeLength -= 1;
                }

                //TODO: Offset of -1 iteration 
            }

            Console.WriteLine(output);
        }
    }
}
