using System;

namespace Task_3
{
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine().ToUpper();
            var count = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            while (count-- > 0)
            {
                sb.Append(Console.ReadLine());
            }
            var text = sb.ToString().ToUpper();
            Console.WriteLine(text);
            var patternIndexInString = text.IndexOf(pattern);
//            Console.WriteLine(Regex.IsMatch(text,@"[.|?]"));
            var dot = text.IndexOf(".", patternIndexInString + pattern.Length - 1);
            var questionMark = text.IndexOf("?", patternIndexInString + pattern.Length - 1);
            var punctuation = dot > questionMark ? "." : "?"; // use REGEX

            if (punctuation == ".")
            {
                
            }
            else
            {
                
            }
        }
    }
}
/*
Statement(.) - The substring starts from the beginning of the sentence(inclusive), till the beginning of the keyword(exclusive) we are looking for.
Question(?) - The substring starts from the end of the keyword(exclusive) we are looking for, till the end of the sentence(without the question mark though).*/

    // result += UpperCase noEmptySpaces