using System;
using System.Collections.Generic;
using System.Text;

namespace _000_Quick
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 10;
            while (b-->0)
            {
                int i = 5;
                while (i-- > 0)
                {
                    Console.WriteLine(i);
                    if (i == 2)
                    {
                        break;
                        //return;
                    }
                }
                Console.WriteLine("HIII: " + b);
            }
          
        }
    }
}
