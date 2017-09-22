using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMR3
{
    class Creator:ICreator
    {
        public IProduct GetProduct(int bestbefore)
        {
            if (bestbefore > 10)
            {
                return new Product(bestbefore);
            }
            else
            {
                return new Product();
            }
        }
    }
}
