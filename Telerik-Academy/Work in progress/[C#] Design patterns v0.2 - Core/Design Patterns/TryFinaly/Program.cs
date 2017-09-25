using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace TryFinaly
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "asd";

            try
            {
                a = null;
                Console.WriteLine(a.ToString());
//                break;
            }
            catch
            {
                Console.WriteLine("aaaaaaa");
            }
            finally
            {
                Console.WriteLine("finaly");
            }


            Console.WriteLine("___________________");
            var dic = new Dictionary<string, int>();

            dic.TryAdd("i", 5);
            string b = null;
//            dic.TryAdd(b, 6);
        }
    }
}
