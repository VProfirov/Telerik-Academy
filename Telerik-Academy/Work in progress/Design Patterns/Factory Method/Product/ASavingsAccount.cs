using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    // What a savings account should represent [as Product]
    public abstract class ASavingsAccount
    {
        public decimal Balance { get; set; }
    }
}
