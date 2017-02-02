using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    //Common Access Interface
    interface ICreditUnionFactory
    {
        ASavingsAccount GetSavingsAccount(string accNum);
    }
}
