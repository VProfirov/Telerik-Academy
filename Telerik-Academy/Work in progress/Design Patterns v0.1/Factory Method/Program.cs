using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a factory and use it [access it] by the common interface
            var factory = new SavingsAccountFactory() as ICreditUnionFactory;
            //// equivalent to ICreditUnionFactor factory = new SavingsAccountFactory();

            var citiAccount = factory.GetSavingsAccount("CITI-312-313");
            var nationalAccount = factory.GetSavingsAccount("NATION-121-03");

            Console.WriteLine($"Citi Account balance: {citiAccount.Balance}");
            Console.WriteLine($"National Savings Account balance: {nationalAccount.Balance}");

        }
    }
}
