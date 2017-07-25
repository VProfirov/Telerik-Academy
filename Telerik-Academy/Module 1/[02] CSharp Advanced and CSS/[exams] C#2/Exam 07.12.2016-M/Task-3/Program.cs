namespace Task_3
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var dimensions = Console.ReadLine();
            var row = int.Parse(dimensions[0].ToString());
            var col = int.Parse(dimensions[2].ToString());
            var denMap = new string[row,col];
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

            var startPosition = 0;
            for (int c = 0; c < col; c++)
            {
                if (denMap[0, c] == "s") startPosition = c;
            }

            ////Conditions - TEMP
            var sneaky = 3;
            var i = 0;
            var moveCount = i++;
            if (moveCount % 5 == 0)
            {
                sneaky--;
            }
            if (denMap[row, col] == "#")
            {
                //// dead hit a wall - result message
                //break;
            }
            if (denMap[row,col] == "*")
            {
                sneaky++;
                denMap[row, col] = "."; //empty space
            }
            if (sneaky == 0)
            {
                //// dead (starved) - result message
                //break;
            }
            var sneakyPositionRow = 0;
            var sneakyPositionCol = 0; // sneakyPositionCol = sneakyPositionCol++ % Col
            if (sneakyPositionRow > row)
            {
                //// lost in depth - result message
                //break;
            }
            if (moveCount == directions.Length)
            {
                //// lost in den = result message
                /// break
            }
        }
    }
}