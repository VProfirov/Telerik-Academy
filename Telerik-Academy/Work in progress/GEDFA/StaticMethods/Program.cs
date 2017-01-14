using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    class Program
    {
        private static string ss1;

        private string s1;
        static void Main(string[] args)
        {
            Console.WriteLine(ss1);
            //            Console.WriteLine(s1); // breaks MAIN is STATIC

            StaticM1();
            Console.WriteLine(ss1);
        }

        public static void StaticM1()
        {
            ss1 = "static string field <-> static method";
//            ss1;
        }

        public void M1()
        {
            ss1 = "static string field <-> NON-S method";
            this.s1 = "non static string field <-> NON-S method";
        }
    }
}
