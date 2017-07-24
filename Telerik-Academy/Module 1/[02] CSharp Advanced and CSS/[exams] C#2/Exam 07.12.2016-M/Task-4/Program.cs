using System;

namespace Task_4
{
    using System.Numerics;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();
            while (count-- > 0) sb.Append(Console.ReadLine() + " ");
            var text = sb.ToString().Trim();

            var patternIndexInString = text.IndexOf(pattern);
            var subStrToCalc = string.Empty;

            for (var i = patternIndexInString; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    subStrToCalc = text.Remove(patternIndexInString);
                    for (var j = patternIndexInString; j >= 0; j--)
                    {
                        if (text[j] >= 'A' && text[j] <= 'Z')
                        {
                            subStrToCalc = subStrToCalc.Substring(j);
                            break;
                        }
                    }
                    break;
                }
                else if (text[i] == '?')
                {
                    subStrToCalc = text.Remove(i);
                    subStrToCalc = subStrToCalc.Substring(patternIndexInString + pattern.Length);
                    break;
                }
            }
            ////Todo: [#mistake3] repetitive computational override of the same variables  ||=> solution: "Answer the question: what is the result?"
            subStrToCalc = subStrToCalc.ToUpper();
            subStrToCalc = subStrToCalc.Replace(" ", string.Empty);

            BigInteger result = 0;
            foreach (var ch in subStrToCalc) result += ch;

            Console.WriteLine(result);
        }
    }
    //// 50% faster, 9% more memory (the ?un-garbaged? references)
}