using System;

namespace Task_3
{
    using System.Numerics;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            while (count-- > 0)
            {
                sb.Append(Console.ReadLine() + " ");
            }
            var text = sb.ToString().Trim();
//            Console.WriteLine(text);

            var patternIndexInString = text.IndexOf(pattern);

            var dotIndex = text.IndexOf(".", patternIndexInString);
            var questionMarkIndex = text.IndexOf("?", patternIndexInString);

            //TODO: Problematic sectio -> punctuation definition
            var punctuation = (dotIndex < questionMarkIndex && dotIndex >= 0 && questionMarkIndex >= 0)? "." : "?"; // use REGEX
            Console.WriteLine("Punctuatio: " + punctuation);

            var subStrToCalc = string.Empty;
            if (punctuation == ".")
            {
                for (int i = patternIndexInString; i >= 0; i--)
                {
                    //                    if (text[i] >= 'A' && text[i] <= 'Z')
                    if (text[i] >= 65 && text[i] <= 90)
                    {
                        subStrToCalc = text.Remove(patternIndexInString);
                        subStrToCalc = subStrToCalc.Substring(i);
                        break;
                    }
                }
            }
            else if (punctuation == "?")
            {
                subStrToCalc = text.Remove(questionMarkIndex);
                Console.WriteLine(subStrToCalc);
                subStrToCalc = subStrToCalc.Substring(patternIndexInString + pattern.Length);
                Console.WriteLine(subStrToCalc);

                // html from html5
            }

            subStrToCalc = subStrToCalc.ToUpper();
//            Console.WriteLine(subStrToCalc);
            subStrToCalc = subStrToCalc.Replace(" ", string.Empty);////imperfect - use regex for all the types of empty spaces
//            Console.WriteLine(subStrToCalc);

            BigInteger result = 0;
            foreach (var ch in subStrToCalc)
            {
                result += ch;
            }

            Console.WriteLine(result);
        }
    }
}
/*
Statement(.) - The substring starts from the beginning of the sentence(inclusive), till the beginning of the keyword(exclusive) we are looking for.
Question(?) - The substring starts from the end of the keyword(exclusive) we are looking for, till the end of the sentence(without the question mark though).*/

    // result += UpperCase noEmptySpaces