using System;
using System.Collections.Generic;

namespace Exceptions_and_Dics
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("IoCContainer_Demo_.Visa");
            //            TryCatch();
            //            Dic();
        }

        public static void TryCatch()
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
        }

        public static void Dic()
        {
            Console.WriteLine("___________________");
            var dic = new Dictionary<string, int>();

            dic.TryAdd("i", 5);
            //            Console.WriteLine(dic["i"]);

            string b = null;
            //                        dic.TryAdd(b, 6);

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
