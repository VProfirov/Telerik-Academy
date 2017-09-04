using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class LoanAccount:ILoanAccount
    {
        public LoanAccount(decimal amount)
        {
            this.Balance = amount;
        }
        public decimal Balance { get;}

        public decimal GetLoanDiscount()
        {
            return this.Balance * 0.20M;
        }
    }
}
