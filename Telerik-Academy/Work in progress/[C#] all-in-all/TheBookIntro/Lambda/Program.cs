using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = "heiii aba daba aba".Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Count(x => x.Length == 3);

            Console.WriteLine(count);

            Func<int, string> wordCount;
            Action<string> printTxt;
        }
    }
}
