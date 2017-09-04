using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Aggregate
{
    using Iterator_Pattern.Iterator;
    class NYPaper:INewspaper
    {
        private readonly List<string> _reporters;
        public NYPaper()
        {
            this._reporters = new List<string>()
                                  {
                                      "Some Ass - NY",
                                      "Fucker Industries - NY",
                                      "Spider Man - NY",
                                      "Guess Who - BATMAN"
                                  };   
        }
        public IIterator CreateIterator()
        {
            return new NYPaperIterator(this._reporters);
        }
    }
}
