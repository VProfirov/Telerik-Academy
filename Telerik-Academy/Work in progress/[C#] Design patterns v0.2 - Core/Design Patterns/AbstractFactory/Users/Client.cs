using System;
using System.Reflection.Metadata;
using AbstractFactory.Banking.BankingProducts;
using AbstractFactory.Banking.BankingProducts.Contracts;
using AbstractFactory.Banking.Banks;

namespace AbstractFactory.Users
{
    public class Client
    {
        private readonly IBankingProduct _loan;
        private readonly IBankingProduct _credit;
        public Client(IBankingFactory factory)
        {
            _loan = factory.CreateLoan();
            _credit = factory.CreateCredit();
        }

        /// <summary>
        /// Access can be granted after verifications of subtypes (client;policies;conditions)
        /// </summary>
        /// <returns>BankingProduct</returns>
        public IBankingProduct AccessLoan() => _loan;
        public IBankingProduct AccessCredit() => _credit;

        //NB! Generally the architecture should be re-thought
    }
}