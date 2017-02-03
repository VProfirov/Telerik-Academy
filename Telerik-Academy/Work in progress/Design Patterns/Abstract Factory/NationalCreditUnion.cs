using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class NationalCreditUnion:ICreditUnionBank
    {
        public ILoanAccount GetLoanAccount(decimal amount)
        {
            return new LoanAccount(amount);
        }

        public ISavingsAccount GetSavingsAccount()
        {
            return new SavingsAccount();
        }
    }
}
