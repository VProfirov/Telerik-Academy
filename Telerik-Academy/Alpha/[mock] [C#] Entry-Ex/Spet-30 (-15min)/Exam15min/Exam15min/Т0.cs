using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam15min
{
    public class T0
    {
        static long Count(int[] combinationList, int listLength, int target)
        {
            var table = new long[target + 1];
            table[0] = 1;
            for (int combinationIndex = 0; combinationIndex < listLength; combinationIndex++)
            {
                for (int index = combinationList[combinationIndex]; index <= target; index++)
                {
                    table[index] += table[index - combinationList[combinationIndex]];
                }
            }
            return table[target];
        }
        public static void Solution()
        {
            var combinationList = new int[] { 2,5,7 };
            int listLength = combinationList.Length;
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine(Count(combinationList, listLength, target));
            Console.ReadLine();
        }
    }
}