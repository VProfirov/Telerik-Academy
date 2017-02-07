using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Iterator
{
    class NYPaperIterator:IIterator
    {
        private readonly List<string> _reporters;

        private int _current;
        public NYPaperIterator(List<string> reporters)
        {
            this._reporters = reporters;
            this._current = 0;
        }

        public void First()
        {
            this._current = 0;
        }

        public string Next()
        {
            return this._reporters[this._current++];
        }

        public bool isDone()
        {
            return this._current >= this._reporters.Count;
        }

        public string Current()
        {
            return this._reporters[this._current];
        }
    }
}
