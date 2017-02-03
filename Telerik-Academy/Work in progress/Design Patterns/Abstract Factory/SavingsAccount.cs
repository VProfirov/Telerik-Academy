using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    using System.Diagnostics.CodeAnalysis;

    class SavingsAccount:ISavingsAccount
    {
        public SavingsAccount()
        {
            
        }

        private SavingsAccount(decimal amount)
        {
            this.Balance = amount;
        }
        public decimal Balance { get; } = 0;

        public ISavingsAccount CreateSavingsAccount(decimal amount) //IList<ISavings>
        {
            return new SavingsAccount(amount);
        }

        public decimal GetSavingsInterest()
        {
            return this.Balance * 10M;
        }
    }
}
