using System;
using System.Runtime.CompilerServices;

namespace AbstractFactory.Banking.BankingProducts.Contracts
{
    using AbstractFactory.Banking.BankingProducts.Process;

    public abstract class AbstractLoan: IBankingProduct
    {
        public decimal Balance { get; private set; } = 2000;
        public void Deposit(decimal amount)
        {
            amount = CashTransaction.ValidateTransaction(amount);
        }

        public decimal Draw(decimal amount)
        {
            amount = CashTransaction.ValidateTransaction(amount);
            if (Balance > amount)
            {
                Balance -= amount;
                return amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds");
                return 0;
            }
        }
    }
}