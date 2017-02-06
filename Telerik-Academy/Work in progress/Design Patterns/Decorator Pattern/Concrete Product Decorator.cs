using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class Concrete_Product_Decorator:Product_Decorator
    {
        public Concrete_Product_Decorator(Product pr)
            : base(pr)
        {
            Description = "First Concrete Product Decorator";
        }

        public override string GetDescription() => $"{this._pr.Description}; {this.Description}";

        public override decimal GetPrice() => this._pr.GetPrice() + 1001;
    }
}
