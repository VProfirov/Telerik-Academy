using System;

namespace Task_1
{
    using System.Numerics;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main(string[] args)
        {
//            Console.WriteLine(int.MaxValue > Math.Pow(2,60));
//            Console.WriteLine(long.MaxValue > (Math.Pow(2,60) * Math.Pow(2, 60) * Math.Pow(2, 60)));
            BigInteger result = 1;
 
//            Console.WriteLine(Hint.HintView());
            var encoding = new string[]
                               {
                                   "ocaml",
                                   "haskell",
                                   "scala",
                                   "f#",
                                   "lisp",
                                   "rust",
                                   "ml",
                                   "clojure",
                                   "erlang",
                                   "standardml",
                                   "racket",
                                   "elm",
                                   "mercury",
                                   "commonlisp",
                                   "scheme",
                                   "curry"
                               };
            var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var inputInHex = new string[3];

            // use string builder for memory efficiency Stringbuilder{(sb)}.Replace(oldV,newV)
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < encoding.Length; j++)
                {
                    if (j>=0 && j <=9)
                    {
                        input[i] = input[i].Replace(encoding[j], j.ToString());
                    }

                    //  Replace is case-sensitive => x>=10 &&& <15 => A-F
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
            
//            foreach (var i in input)
//            {
//                Console.WriteLine(i);
//            }
        }
    }
}
/*How many digits does this numeral system have? Is there an appropriate built-in functionality?
String.Replace can simplify things a lot, just be careful in what order you replace
Think about the data types of the three numbers and the result - how much is 2^60 * 2^60 * 2^60?*/