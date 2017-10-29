using System;
using System.Collections.Generic;

namespace TryFinaly
{
    public class Dictionary_Props_init
    {
        public  static void Dic()
        {
            var dic = new Dictionary<string, int>();
            dic.Add("five", 5);
            dic["t"] = 2;
//                        Console.WriteLine(dic["t"]);
            
            foreach (var d in dic)
            {
                Console.WriteLine(d);
            }
        }
    }
}