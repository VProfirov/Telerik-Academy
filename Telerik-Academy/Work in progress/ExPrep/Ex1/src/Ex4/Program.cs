using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var arrNums = new int[count];
            for (int i = 0; i < count; i++)
            {
                arrNums[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
