using System;
using AbstractFactory.Banking.Banks;
using AbstractFactory.Banking.Banks.ConcreteBanks;
using AbstractFactory.Users;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularFactory = new RegularProductsFactory() as IBankingFactory;
            var client = new Client(regularFactory);
        }
    }
}
