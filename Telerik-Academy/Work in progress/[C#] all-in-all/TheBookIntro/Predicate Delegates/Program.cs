using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Delegates
{
    class Program
    {
        delegate void PrinterDelegate(string str);
        static void Main(string[] args)
        {
            
            Action<string> printing = s => Console.WriteLine(s);
            PrinterDelegate pDelegate = s => Console.WriteLine(s);

            int count = 0;
            while (count++ <5)
            {
                pDelegate += s => Console.WriteLine(s);
//                Console.WriteLine(count);
                printing += s => Console.WriteLine(s);
            }

            pDelegate("Delegate ");
            printing("Predicate Delegate");
        }
    }
}
