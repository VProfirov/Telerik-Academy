using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    // Concrete implementation of A Savings Account
    public class CitiSavingsAccount:ASavingsAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 500;
        }
    }
}
