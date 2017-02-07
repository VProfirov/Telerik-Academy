using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_pattern.Observer
{
    using Observer_pattern.Subject;
    interface IFan
    {
        void Update(ICelebrity celebrity);
    }
}
