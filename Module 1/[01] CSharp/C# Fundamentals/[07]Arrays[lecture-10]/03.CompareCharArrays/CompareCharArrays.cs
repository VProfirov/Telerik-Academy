/* Write a program that compares 
 * two char arrays lexicographically (letter by letter).
 */
namespace CompareCharArrays
{
    using System;

    public class CompareCharArrays
    {
        public static void Main()
        {
            var chArr1 = Console.ReadLine();
            var chArr2 = Console.ReadLine();

            var maxArrCompareSize = chArr1.Length < chArr2.Length ? chArr1.Length : chArr2.Length;
            var lexicographicRelation = "=";
            for (int i = 0; i < maxArrCompareSize; i++)
            {
                if (chArr1[i] < chArr2[i])
                {
                    lexicographicRelation = "<";
                    break;
                }
                else if (chArr1[i] > chArr2[i])
                {
                    lexicographicRelation = ">";
                    break;
                }
            }

            Console.WriteLine(lexicographicRelation);
        }
    }
}