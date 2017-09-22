using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    class Human:IHuman
    {
        public IOwner GetMeOwner(string gender)
        {
            if (gender == "man")
            {
                return new Man();
            }
            else
            {
                return new Woman();
            }
        }
    }
}
