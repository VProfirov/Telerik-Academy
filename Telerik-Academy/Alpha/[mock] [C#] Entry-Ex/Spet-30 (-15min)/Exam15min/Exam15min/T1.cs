using System;

namespace Exam15min
{
    public class T1
    {
        public static void Solution()
        {
            var input = "";
            var first = 0;
            var second = 0;
            var third = 0;
            var result = 0;
            while (true)
            {
                input = Console.ReadLine();
                first = int.Parse(input[0].ToString());
                second = int.Parse(input[1].ToString());
                third = int.Parse(input[2].ToString());

                if (first + third == second)
                {
                    result += int.Parse(input);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}