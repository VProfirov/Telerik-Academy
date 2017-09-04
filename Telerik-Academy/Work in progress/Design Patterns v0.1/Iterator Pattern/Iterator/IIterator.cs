using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Iterator
{
    interface IIterator
    {
        void First();

        string Next();

        bool isDone();

        string Current();
    }
}
