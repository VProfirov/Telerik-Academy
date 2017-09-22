using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMemembers
{
    class Program
    {
        public static readonly int num = 50;

        public static readonly string str = "string";

        static void Main(string[] args)
        {
            Console.WriteLine(Program.I);
            Console.WriteLine(Program.S);

        }

        public static int I { get; } = 5;

        public static string S { get; } = "str";
    }
}
