using System;
using AbstractFactory.Banking.BankingProducts.Process;

namespace AbstractFactory.Banking.BankingProducts
{
    using AbstractFactory.Banking.BankingProducts.Contracts;

    public class StudentCredit:AbstractCredit
    {
        private decimal BalanceLimit = 1000;

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
                Console.WriteLine("Insufficient Credit. Do you want to extend your credit with 20$? y/n");
                var answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    
                    if (ScholarshipCover(20))
                    {
                        Balance += 20;
                        BalanceLimit += 20;
                    }
                }
                return 0;
            }
        }

        private bool ScholarshipCover(decimal requestedAmount)
        {
            var scholarship = 2000;
            if (scholarship>requestedAmount)
            {
                return true;
            }
            return false;
        }
    }
}