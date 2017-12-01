using System;
using System.Collections.Generic;

namespace TheD
{
    public class Class2
    {
        public static void S2_2()
        {
            var result = Combinations(new List<string> { "1", "2", "3", "4", "5" }, 3);

            foreach (var combination in result)
            {
                Console.WriteLine(combination);
            }
        }

        static IEnumerable<string> Combinations(List<string> characters, int length)
        {
            for (int i = 0; i < characters.Count; i++)
            {
                // ако листът има 1 елемент, алгоритъмът го връща
                if (length == 1)
                    yield return characters[i];
                // генерира всички комбинации, без повторения    
                else
                    foreach (string next in Combinations(characters.GetRange(i + 1, characters.Count - (i + 1)), length - 1))
                    {
                        yield return characters[i] + next;
                    }
            }
        }
    }
}