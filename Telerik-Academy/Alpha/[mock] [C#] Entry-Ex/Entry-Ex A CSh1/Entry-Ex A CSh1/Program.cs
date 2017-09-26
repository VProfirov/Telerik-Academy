using System;
using System.Linq;
using static Entry_Ex_A_CSh1.Numbers_Task1;

namespace Entry_Ex_A_CSh1
{
    class Program
    {
        static void Main(string[] args)
        {
//            Solution_T1();

            var input = "asd 100 100 100";
            var data = input.Split(" ");
            var command = data[0];

            var tmp = string.Concat(data.TakeLast(data.Length - 1));
            Console.WriteLine(tmp.Length);
            Console.WriteLine(data.Length);
            Console.WriteLine(tmp);
        }
    }
}