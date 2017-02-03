using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new CreditUnionBankProvider();
            var bank = provider.GetCreditUnionFactory("CitiCreditUnion Bank");
            var account = bank.GetSavingsAccount();

            Console.WriteLine(account.Balance);
            Console.WriteLine(account.GetSavingsInterest());
        }
    }
}
