using System;

namespace AbstractFactory.Banking.BankingProducts.Process
{
    public static class CashTransaction
    {
        public static decimal ValidateTransaction(decimal amount)
        {
            if (amount > 0)
            {
                return amount;
            }
            else
            {
                Console.WriteLine("Amount must be positive");
                return 0;
            }
        }
    }
}