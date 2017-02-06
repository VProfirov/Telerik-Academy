using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class ConcreteProduct:Product
    {
        public ConcreteProduct()
        {
            this.Description = "Compact car";
        }
        public override string GetDescription() => this.Description;

        public override decimal GetPrice() => 10m;
    }
}
