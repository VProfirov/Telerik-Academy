using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string resultStrNumber = "";
            string strNumber = "";
            var outputSB = new StringBuilder();

            while (input != "end")
            {
                var data = input.Split(new char[]{' ',',','.' },StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                //                var strNumber = string.Concat(data.TakeLast(data.Length - 1));
                if (data.Length > 1)
                {
                    strNumber = string.Concat(ExtractNumbers(data));
                }
                switch (command)
                {
                    case "set":
                        resultStrNumber = strNumber;
                        break;
                    case "front-add":
                        resultStrNumber = string.Concat(strNumber, resultStrNumber);
                        break;
                    case "front-remove":
                        if (resultStrNumber.Length > 0)
                        {
                            resultStrNumber = resultStrNumber.Remove(0, 1);
                        }
                        break;
                    case "back-add":
                        resultStrNumber = string.Concat(resultStrNumber, strNumber);
                        break;
                    case "back-remove":
                        if (resultStrNumber.Length > 0)
                        {
                            resultStrNumber = resultStrNumber.Remove(resultStrNumber.Length - 1);
                        }
                        break;
                    case "reverse":
//                        resultStrNumber = string.Concat(resultStrNumber.Reverse());
                        resultStrNumber = Reverse(resultStrNumber);
                        break;
                    case "print":
//                        Console.WriteLine(resultStrNumber);
                        outputSB.AppendLine(resultStrNumber);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(outputSB.ToString().Trim());
        }

        public static string[] ExtractNumbers(string[] str)
        {
            var result = new string[str.Length - 1];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = str[i + 1];
            }
            return result;
        }

        public static string Reverse(string str)
        {
            var sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
