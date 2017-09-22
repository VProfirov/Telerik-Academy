using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class Product_Decorator:Product
    {
        protected Product _pr;
        public Product_Decorator(Product pr)
        {
            this._pr = pr;
        }

        public override string GetDescription() => this._pr.GetDescription();

        public override decimal GetPrice() => this._pr.GetPrice();
    }
}
