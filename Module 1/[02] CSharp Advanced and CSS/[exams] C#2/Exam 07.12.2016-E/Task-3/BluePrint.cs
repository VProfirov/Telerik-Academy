using System;
using System.Linq;

namespace Task_3
{
    public class BluePrint
    {
        public void DEMO()
        {
            var dimensions = Console.ReadLine().Split('x').Select(int.Parse).ToArray(); // as int[] null error
            var matrix = new char[dimensions[0]][];

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }
            var directions = Console.ReadLine().Split(',').Aggregate((previous, current) => previous + current)
                .ToCharArray();
            var position = 0;
            for (var i = 0; i < matrix[0].Length; i++)
            {
                if (matrix[0][i] == 'e')
                {
                    position = i;
                    break;
                }
            }

            //denUtilityCheck(matrix);
            void denUtilityCheck(char[][] denMap)
            {
                for (var r = 0; r < denMap.Length; r++)
                {
                    for (var c = 0; c < denMap[r].Length; c++)
                        Console.Write(denMap[r][c]);
                    Console.WriteLine();
                }
            }

            void denUtility_MoveParser(char[][] denMap, int R, int C)
            {
                for (var r = 0; r < denMap.Length; r++)
                {
                    for (var c = 0; c < denMap[r].Length; c++)
                        if (r == R && c == C)
                            Console.Write("*");
                        else
                            Console.Write(denMap[r][c]);
                    Console.WriteLine();
                }
            }

            var row = 0;
            var col = position;
            var snakeLength = 3; //starts with
            var move = 1; // %5 => snake -=1
            var output = String.Empty;
            var keepMoving = true; //TODO: track

            denUtility_MoveParser(matrix, row, col);
            for (var i = 0; i < directions.Length; i++)
            {
                //change direction
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

                denUtility_MoveParser(matrix, row, col);

                //account effects of taken direction according to the universe|den
                if (row >= matrix.Length)
                {
                    output = $"Sneaky is going to be lost into the depths with length {snakeLength}";
                    keepMoving = false;
                    break;
                }
                if (col >= matrix[row].Length) //dimension confirmation check -|+
                    col = 0;
                if (col < 0)///mistake
                    col = matrix[row].Length - 1;

                //consume on move
                switch (matrix[row][col])
                {
                    //                    case '-':break;
                    case '%':
                        output = $"Sneaky is going to hit a rock at [{row},{col}]";
                        keepMoving = false;
                        break;
                    case '@':
                        snakeLength += 1;
                        matrix[row][col] = '-'; //egg eaten
                        break;
                    case 'e':
                        output = $"Sneaky is going to get out with length {snakeLength}";
                        keepMoving = false;
                        break;
                }
                //                denUtility_MoveParser(matrix, row, col);

                //snake state 
                if (snakeLength == 0)
                {
                    output = "Sneaky is going to starve at [R,C]";
                    keepMoving = false;
                }
                if (move % 5 == 0) //move's count %5 snake slim check
                    snakeLength -= 1;
                //death|exit?


                if (!keepMoving) break;

                //TODO: Offset of -1 iteration 
            }
            if (string.IsNullOrEmpty(output))
            {
                output = $"Sneaky is going to be stuck in the den at [{row},{col}]";
            }
            Console.WriteLine(output);
        }
    }
}