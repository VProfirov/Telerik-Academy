using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    using System.Numerics;

    public class solution_40p
    {
        public static void Solution()
        {
            // Console.WriteLine(int.MaxValue > Math.Pow(2,60));
            // Console.WriteLine(long.MaxValue > (Math.Pow(2,60) * Math.Pow(2, 60) * Math.Pow(2, 60)));
            BigInteger result = 1;

            // Console.WriteLine(Hint.HintView());
            var encoding = new[]
                               {
                                   "ocaml", "haskell", "scala", "f#", "lisp", "rust", "ml", "clojure", "erlang",
                                   "standardml", "racket", "elm", "mercury", "commonlisp", "scheme", "curry"
                               };
            //TODO: i! self containing keywords in the encoding list => reorder !the lookup! from longest to shortest
            var input = Console.ReadLine().ToLower().Split(
                new[] { ", " },
                StringSplitOptions.RemoveEmptyEntries);
            var inputInHex = new string[3];

            // use string builder for memory efficiency Stringbuilder{(sb)}.Replace(oldV,newV)
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < encoding.Length; j++)
                {
                    // reason for 40% inproper Replace ordering => couse : self including keywords in the encoding table (ex: lisp <=> commonlisp; etc...)
                    if (j >= 0 && j <= 9)
                    {
                        input[i] = input[i].Replace(encoding[j], j.ToString());
                    }

                    // Replace is case-sensitive => x>=10 &&& <15 => A-F
                    if (j >= 10 && j <= 15)
                    {
                        var h = Convert.ToString(j, 16).ToUpper();
                        input[i] = input[i].Replace(encoding[j], h);
                    }
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                var longVal = Convert.ToInt64(input[i], 16);
                result *= longVal;
            }

            Console.WriteLine(result);

            // foreach (var i in input)
            // {
            // Console.WriteLine(i);
            // }
        }
    }
}