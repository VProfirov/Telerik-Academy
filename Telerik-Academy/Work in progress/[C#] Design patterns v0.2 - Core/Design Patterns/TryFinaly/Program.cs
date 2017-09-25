using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using IoCContainer_Demo_;
namespace TryFinaly
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("IoCContainer_Demo_.Visa");
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
            string b = null;
            //            dic.TryAdd(b, 6);
        }
    }
}
