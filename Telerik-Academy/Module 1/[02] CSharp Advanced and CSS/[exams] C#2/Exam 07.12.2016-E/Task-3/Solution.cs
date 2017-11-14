using System;
using System.Linq;

namespace Task_3
{
    public class Solution
    {
        public static void DEMO()
        {
            var dimensions = Console.ReadLine().Split('x').Select(int.Parse).ToArray(); // as int[] null error
            var matrix = new char[dimensions[0]][];

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }
            var directions = Console.ReadLine().Split(',').Aggregate((previous, current) => previous + current).ToCharArray();
            var position = 0;
            for (var i = 0; i < matrix[0].Length; i++)
            {
                if (matrix[0][i] == 'e')
                {
                    position = i;
                    break;
                }
            }

            var row = 0;
            var col = position;
            var snakeLength = 3;
            var move = 1;
            var output = String.Empty;
            var keepMoving = true;
            for (var i = 0; i < directions.Length; i++)
            {
                switch (directions[i])
                {
                    case 's':
                        row += 1;
                        break;
                    case 'w':
                        row -= 1;
                        break;
                    case 'a':
                        col -= 1;
                        break;
                    case 'd':
                        col += 1;
                        break;
                    default: throw new ArgumentException("wrong direction passed");
                }
                move += 1;

                if (row >= matrix.Length)
                {
                    output = string.Format("Sneaky is going to be lost into the depths with length {0}", snakeLength);
                    keepMoving = false;
                    break;
                }
                if (col >= matrix[row].Length) col = 0;
                if (col < 0) col = matrix[row].Length - 1;

                switch (matrix[row][col])
                {
                    case '%':
                        output = string.Format("Sneaky is going to hit a rock at [{0},{1}]", row, col);
                        keepMoving = false;
                        break;
                    case '@':
                        snakeLength += 1;
                        matrix[row][col] = '-'; //egg eaten
                        break;
                    case 'e':
                        output = string.Format("Sneaky is going to get out with length {0}", snakeLength);
                        keepMoving = false;
                        break;
                }

                if (snakeLength == 0)
                {
                    output = "Sneaky is going to starve at [R,C]";
                    keepMoving = false;
                }
                if (move % 5 == 0) snakeLength -= 1;


                if (!keepMoving) break;
            }
            if (string.IsNullOrEmpty(output))
            {
                output = string.Format("Sneaky is going to be stuck in the den at [{0},{1}]", row, col);
            }
            Console.WriteLine(output);
        }
    }
}