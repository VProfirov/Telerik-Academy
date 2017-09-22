using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Aggregate
{
    using Iterator_Pattern.Iterator;

    class LAPaper:INewspaper
    {
        private readonly string[] _reporters;
        public LAPaper()
        {
            this._reporters = new[] { "Ronald Smith - LA", "Donald Smith - LA", "Brad Pit - LA", "Brad Smith - LA" };
        }
        public IIterator CreateIterator()
        {
            return new LAPaperIterator(_reporters);
        }
    }
}
