using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonyTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var anonyArr = new[]
                               {
                                   new { X = 3, Y = 1},
//                                   new { X = 3, Y = 1, Z = 2}, // breaks the AnonyType[]
                                   new { X = 3, Y = 1}
                               };
        }
    }
}
