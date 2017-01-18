using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 60;
            int col = 150;
            int border = 10;
            for (int i = 0; i < row - border ; i++)
            {
                Console.WriteLine("{0}",new string('#',col - border));
            }
        }
    }
}
