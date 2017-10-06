using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Banking.BankingProducts.Process;

namespace AbstractFactory.Banking.BankingProducts.Contracts
{
    public class AbstractCredit:IBankingProduct
    {
//        static AbstractCredit()
//        {
//            Balance = 500;
//        }

        public decimal Balance { get; } = 500;//TODO el problemo : set??+

        private decimal BalanceLimit = 5000;

        public void Deposit(decimal amount)
        {
            amount = CashTransaction.ValidateTransaction(amount);
        }

        public virtual decimal Draw(decimal amount)
        {
            amount = CashTransaction.ValidateTransaction(amount);
            if (Balance > amount)
            {
                Balance -= amount;
                return amount;
            }
            else
            {
                Console.WriteLine("Insufficient Credit. Do you want to extend your credit with 200$? y/n");
                var answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    Balance += 200;
                    BalanceLimit += 200;
                }
                return 0;
            }
        }
    }
}
