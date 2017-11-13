using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public static class Utility
    {
        public static void ConsolePrint(string[] directions, string[,] denMap)
        {
             Console.WriteLine();
            foreach (var direction in directions)
            {
                Console.Write(direction);
            }

            Console.WriteLine();
            for (int r = 0; r < denMap.GetLength(0); r++)
            {
                for (int c = 0; c < denMap.GetLength(1); c++)
                {
                    Console.Write(denMap[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
