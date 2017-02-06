using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    abstract class Product
    {
        public string Description { get; set; }

        public abstract string GetDescription();

        public abstract decimal GetPrice();
    }
}
