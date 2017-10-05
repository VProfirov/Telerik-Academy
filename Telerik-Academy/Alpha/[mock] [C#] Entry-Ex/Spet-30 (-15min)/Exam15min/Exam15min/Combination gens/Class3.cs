using System;

namespace TheD
{
    public class Class3
    {
        static int combinationPosition;
        static int[] combination;

        private static void PrintCombinations(int lastElement, int numberOfUnusedElements, int numberOfElementsInCombination, int n)
        {
            //bottom of the recursion
            if (numberOfUnusedElements == 0)
            {
                string combinationOutput = string.Join(", ", combination);

                Console.WriteLine(combinationOutput);
            }

            if (numberOfUnusedElements > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    //to get combination, but not a variation we check if the last element is smaller than i
                    //the same logic as the variation generation with the difference that we have one variable for the last element
                    if (i > lastElement)
                    {
                        combination[combinationPosition++] = i;

                        PrintCombinations(i, numberOfUnusedElements - 1, numberOfElementsInCombination, n);

                        combinationPosition--;
                    }
                }
            }
        }
        public static void S2_3()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            combination = new int[k];

            PrintCombinations(0, k, k, n);
        }
    }
}