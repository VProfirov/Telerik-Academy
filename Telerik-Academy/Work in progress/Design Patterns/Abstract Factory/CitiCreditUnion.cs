using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class CitiCreditUnion:ICreditUnionBank
    {
        public ILoanAccount GetLoanAccount(decimal amount)
        {
            return new LoanAccount(amount); // typical for the City Loan Account (re impl)
        }

        public ISavingsAccount GetSavingsAccount()
        {
            return new SavingsAccount();  // typical for the City Savings Account (re impl)
        }
    }
}
