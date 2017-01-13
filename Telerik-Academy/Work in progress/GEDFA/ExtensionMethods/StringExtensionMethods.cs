using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class StringExtensionMethods
    {
        public static string PoliteToString(this string str)
        {
            return $"Hello : {str}";
        }

        //static CANT be override
//        public static override string ToString()
//        {
//            return "s";
//        }
    }
}
