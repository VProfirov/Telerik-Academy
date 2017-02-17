using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    interface IHuman
    {
        IOwner GetMeOwner(string gender);
    }
}
