using System;

namespace Task_1
{
    using System.Numerics;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main(string[] args)
        {
//            Console.WriteLine(Hint.HintView_v02_Horner());

            var encodedNumbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            var product = new BigInteger(1);

            foreach (var encodedNumber in encodedNumbers)
            {
                var hexNumber = new StringBuilder(encodedNumber)
                                                    .Replace("commonlisp", "D")
                                                    .Replace("standardml", "9")
                                                    .Replace("haskell", "1")
                                                    .Replace("mercury", "C")
                                                    .Replace("clojure", "7")
                                                    .Replace("erlang", "8")
                                                    .Replace("scheme", "E")
                                                    .Replace("racket", "A")
                                                    .Replace("curry", "F")
                                                    .Replace("ocaml", "0")
                                                    .Replace("scala", "2")
                                                    .Replace("lisp", "4")
                                                    .Replace("rust", "5")
                                                    .Replace("elm", "B")
                                                    .Replace("ml", "6")
                                                    .Replace("f#", "3")
                                                    .ToString();

                product *= new BigInteger(Convert.ToInt64(hexNumber, 16));
            }

            Console.WriteLine(product);
        }
    }
}