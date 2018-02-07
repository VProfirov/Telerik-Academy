using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTesting_Template
{
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();

            //tested material

            sw.Stop();

            Console.Write("Passed time: " + sw.ElapsedTicks + "\n");
            sw.Reset();
        }
    }
}
