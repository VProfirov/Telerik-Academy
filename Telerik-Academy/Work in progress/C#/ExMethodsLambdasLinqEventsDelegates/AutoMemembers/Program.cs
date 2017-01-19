using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMemembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.I);
            Console.WriteLine(Program.S);

        }

        public static int I { get; } = 5;

        public static string S { get; } = "str";
    }
}
