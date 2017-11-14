using System;
using System.Linq;

namespace Task_3
{
    public class Ref_Morning
    {
        public static void DEMO()
        {
            var dimensions = Console.ReadLine().Split('x').Select(int.Parse).ToArray();
            var row = dimensions[0];
            var col = dimensions[1];
            var denMap = new string[row, col]; //**REF
            //TODO: NOTE: denMap - might be better to be jagged-array!

            for (int r = 0; r < row; r++)
            {
                var imprintRow = Console.ReadLine();
                for (int c = 0; c < col; c++)
                {
                    denMap[r, c] = imprintRow[c].ToString();
                }
            }

            var directions = Console.ReadLine().Split(',');

            ////            Utility.ConsolePrint(directions,denMap);

            int[] startPosition = {0, 0}; //**REF-chain:sp0
            for (int c = 0; c < col; c++)
            {
                if (denMap[0, c] == "s") startPosition[1] = c;
            }

            var message = string.Empty;
            var snakeLength = 3;
            var moveCount = 0;
            var snakeCurrentPosition = startPosition; //**?REF:sp0
            var shouldContinue = true;
            do
            {
                snakeCurrentPosition = ExecuteMove(snakeCurrentPosition, directions[moveCount]);

                if ((moveCount + 1) % 5 == 0)
                {
                    snakeLength--;
                }

                if (snakeLength <= 0)
                {
                    message = string.Format("Sneaky will starve at [{0},{1}]", snakeCurrentPosition[0],
                        snakeCurrentPosition[1]);
                    shouldContinue = false;
                    break;
                }
                if (snakeCurrentPosition[0] >= denMap.GetLength(0))
                {
                    message = string.Format("Sneaky will be lost into the depths with length {0}", snakeLength);
                    shouldContinue = false;
                    break;
                }

                // #AlgoStep #0 Edge Looping - YES - looking for
                snakeCurrentPosition = CheckForRightLeftLoop(snakeCurrentPosition, denMap);

                // TODO: Improve Documentation skills
                ///<INFO>
                /// <NOTE>: Edge Bouncing => the direction REVERSES for each move in a perticular direction-instruction </NOTE>>
                /// <CODE: Pseudo (left {of left-edge} + left == right + right)> for position += 1 * isChange(-1)</Pseudo>
                /// <NOTE>: Edge Bumping => the direction IS UNCHANGED, but CAN'T GO OVER THE EDGE</NOTE>
                /// <CODE snakeCurrentPosition[1] = Math.Abs(snakeCurrentPosition[1] % denMap.GetLength(1));> for position++ </CODE>
                /// <NOTE>: Edge Looping => goes from the other/opposite side, when the same direction persist at state of reaching the edge</NOTE>
                /// <CODE if (snakeCurrentPosition[1] isLessThan 0){snakeCurrentPosition[1] = denMap.GetLength(1) - 1;}></CODE>
                ///</INFO>

                // in den moving & den-morphing
                switch (denMap[snakeCurrentPosition[0], snakeCurrentPosition[1]]) // out of range - 5
                {
//                    case ".": break;
                    case "@":
                        snakeLength++;
                        denMap[snakeCurrentPosition[0], snakeCurrentPosition[1]] = "-";
                        break;
                    case "%":
                        message = string.Format("Sneaky will hit a rock at [{0},{1}]", snakeCurrentPosition[0],
                            snakeCurrentPosition[1]);
                        shouldContinue = false;
                        break;
                    case "e":
                        message = string.Format("Sneaky will get out with length {0}", snakeLength);
                        shouldContinue = false;
                        break;
                }
            } while ((directions.Length > ++moveCount) && shouldContinue); // movecount out of bound

            if (string.IsNullOrEmpty(message))
            {
                message = string.Format("Sneaky will be stuck in the den at [{0},{1}]", snakeCurrentPosition[0],
                    snakeCurrentPosition[1]);
            }

            Console.WriteLine(message);
        }

        private static int[] ExecuteMove(int[] position, string direction)
        {
            switch (direction)
            {
                case "d":
                    position[0]++;
                    break;
                case "u":
                    position[0]--;
                    break;
                case "r":
                    position[1]++;
                    break;
                case "l":
                    position[1]--;
                    break;
            }
            return position;
        }

        private static int[] CheckForRightLeftLoop(int[] snakeCurrentPosition, string[,] denMap)
        {
            // edge looping
            if (snakeCurrentPosition[1] < 0)
            {
                snakeCurrentPosition[1] = denMap.GetLength(1) - 1;
            }
            else if (snakeCurrentPosition[1] >= denMap.GetLength(1))
            {
                snakeCurrentPosition[1] = 0;
            }
            return snakeCurrentPosition;
        }
    }
}