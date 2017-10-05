using System;
using System.Text;

namespace Exam15min
{
    public class T3
    {
        public static void Solution()
        {
            var input = Console.ReadLine();
            var checker = -1;
            var result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != checker)
                {
                    result.Append(input[i]);
                    checker = input[i];
                }
                else
                {
                    checker = input[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}