using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam15min
{
    public class T0
    {
        /// <summary>
        /// Trying to solve it the wrong/long way
        /// </summary>
        public static void Solution()
        {
            var codeCombiners = new List<int>() { 2, 5, 7 }; // ordered
            var flagCombiners = new List<bool>() { false, false, false };
            var target = int.Parse("17"); //TODO: CR()
            var combinationSequencer = new List<int>(GetMaxPositions(codeCombiners[0], target));
            //check target >= codeCombiners[0]
            Population(combinationSequencer, codeCombiners[0]);

            // nextCombination: flag and cycle
            //check result == target ? counter++ : nextCombination{<= target ?T move}
            //check flaged T T T ? move

            Console.WriteLine(codeCombiners.Sum());
        }

        static int GetMaxPositions(int smallest, int target)
        {
            return target / smallest;
        }

        static IList<int> Population(IList<int> list, int seed)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list.Add(seed);
            }
            return list;
        }

        public static void SolutionOfOther()
        {
            int legs = int.Parse(Console.ReadLine());
            int chicken = 7;
            int human = 5;
            int bear = 2;
            int cases = 0;
            int mostChickenLegs = legs / chicken;
            int mostHumanLegs, mostBearLegs;

            for (int i = mostChickenLegs; i >= 0; i--)
            {
                mostHumanLegs = (legs - i * chicken);
                mostHumanLegs /= human;
                for (int j = mostHumanLegs; j >= 0; j--)
                {
                    mostBearLegs = legs - (i * chicken + j * human);
                    int z = mostBearLegs / bear;
                    if (i * chicken + j * human + z * bear == legs)
                        cases++;
                }
            }
            Console.WriteLine(cases);
        }
    }
}