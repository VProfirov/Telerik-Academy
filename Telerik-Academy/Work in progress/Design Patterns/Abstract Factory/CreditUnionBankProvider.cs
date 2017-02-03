using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    using System.Security.Cryptography.X509Certificates;

    class CreditUnionBankProvider
    {
        public ICreditUnionBank GetCreditUnionFactory(string accBranch)
        {
            if (accBranch.ToLower().Contains("national"))
            {
               return new NationalCreditUnion();
            }
            else if (accBranch.ToLower().Contains("citi"))
            {
               return new CitiCreditUnion();
            }
            else
            {
               throw new ArgumentException("No Factory Aveilable");
            }
        }
    }
}
