using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMR3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreator creator = new Creator();
            var cr = new Creator() as ICreator;

            var prod = cr.GetProduct(50);

            Console.WriteLine(prod.Age);
        }
    }
}
