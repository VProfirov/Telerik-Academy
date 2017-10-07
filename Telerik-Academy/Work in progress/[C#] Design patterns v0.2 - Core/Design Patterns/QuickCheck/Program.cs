using System;
using System.Collections.Generic;

namespace QuickCheck_AIProp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, int>();
            dic.Add("five",5);
            dic["t"] = 2;
//            Console.WriteLine(dic["t"]);

            foreach (var d in dic)
            {
                Console.WriteLine(d);
            }
        }
    }

   
}
