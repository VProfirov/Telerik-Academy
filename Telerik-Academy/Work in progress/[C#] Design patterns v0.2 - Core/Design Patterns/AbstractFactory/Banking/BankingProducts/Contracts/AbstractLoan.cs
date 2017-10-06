using System;

namespace AbstractFactory.Banking.BankingProducts.Contracts
{
    using AbstractFactory.Banking.BankingProducts.Process;

    public class AbstractLoan: IBankingProduct
    {
        public AbstractLoan()
        {
            Balance = 2000;
        }

        public decimal Balance { get; } //TODO el problemo : set??+
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