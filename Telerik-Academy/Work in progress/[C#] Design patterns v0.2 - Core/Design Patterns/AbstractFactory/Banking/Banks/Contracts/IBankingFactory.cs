using System;
using AbstractFactory.Banking.BankingProducts;
using AbstractFactory.Banking.BankingProducts.Contracts;

namespace AbstractFactory.Banking.Banks
{
    public interface IBankingFactory
    {
        IBankingProduct CreateLoan();
        IBankingProduct CreateCredit();
    }
}