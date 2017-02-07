using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Aggregate
{
    using Iterator_Pattern.Iterator;

    interface INewspaper
    {
        IIterator CreateIterator();
    }
}
