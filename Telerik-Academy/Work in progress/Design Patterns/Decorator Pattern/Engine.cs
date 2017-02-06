using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class Engine
    {
        static void Main(string[] args)
        {
            Product pr = new ConcreteProduct();
            pr = new Concrete_Product_Decorator(pr);

            Console.WriteLine(pr.GetPrice());
            Console.WriteLine(pr.GetDescription());
        }
    }
}
