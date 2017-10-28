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

            int[] mixArr = new int[count-1];
            int[] subArr = new int[count - 1];

            for (int i = 0; i < count -1 ; i++)
            {
                int fD = arrNums[i] % 10;
                int sD = (arrNums[i + 1] / 10) % 10;

                mixArr[i] = fD * sD;
                subArr[i] = Math.Abs(arrNums[i] - arrNums[i + 1]);
            }

            Console.WriteLine(string.Join(" ",mixArr));
            Console.WriteLine(string.Join(" ",subArr));
        }
    }
}
