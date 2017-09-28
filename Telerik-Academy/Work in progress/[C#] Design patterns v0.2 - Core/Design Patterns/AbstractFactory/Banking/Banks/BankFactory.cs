using System;
using AbstractFactory.Banking.BankingProducts;

namespace AbstractFactory.Banking.Banks
{
    public abstract class BankFactory
    {
        private readonly Loan loan;
        private readonly Credit credit;

        public Loan LoanBalance { get; }
        public Loan LoanDeposite { get}

    }
}