using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    interface ILoanAccount
    {
        decimal Balance { get; }

//        ILoanAccount CreateLoanAccount(decimal amount);
        decimal GetLoanDiscount();
    }
}
