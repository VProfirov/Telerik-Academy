using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    //Concrete [Factory Method] Creator : 
    class SavingsAccountFactory:ICreditUnionFactory
    {
        ////The Factory Method
        public ASavingsAccount GetSavingsAccount(string accNum)
        {
            if (accNum.Contains("CITI"))
            {
                return new CitiSavingsAccount();
            }
            else if (accNum.Contains("NATION"))
            {
                return new NationalSavingsAccount();
            }
            else
            {
                throw new ArgumentException("There is no such account");
            }
        }
    }
}
