using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace Exam15min
{
    public class T2
    {
        public static void Solution()
        {
            var codeCombiners = new List<int>(){2,5,7}; // ordered
            var flagCombiners = new List<bool>() {false, false, false};
            var target = int.Parse("17"); //TODO: CR()
            var combinationSequencer = new List<int>(GetMaxPositions(codeCombiners[0],target));
            //check target >= codeCombiners[0]
            Population(combinationSequencer, codeCombiners[0]);

            // nextCombination: flag and cycle
            //check result == target ? counter++ : nextCombination{<= target ?T move}
            //check flaged T T T ? move
            
            Console.WriteLine(codeCombiners.Sum());
        }

        static int GetMaxPositions(int smallest,int target)
        {
            return target / smallest;
        }

        static IList<int> Population(IList<int> list,int seed)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list.Add(seed);
            }
            return list;
        }
    }
}