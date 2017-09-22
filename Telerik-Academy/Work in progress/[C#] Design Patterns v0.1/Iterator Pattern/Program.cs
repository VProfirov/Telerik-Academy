using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    using Iterator_Pattern.Aggregate;
    using Iterator_Pattern.Iterator;

    class Program
    {
        static void Main(string[] args)
        {
            INewspaper nyr = new NYPaper();
            INewspaper lar = new LAPaper();

            IIterator nyrIterator = nyr.CreateIterator();
            IIterator larIterator = lar.CreateIterator();

            Console.WriteLine("New York ------");
            PrintReporters(nyrIterator);

            Console.WriteLine("LA-------------");
            PrintReporters(larIterator);
        }

        static void PrintReporters(IIterator iterator)
        {
            iterator.First();
            while (!iterator.isDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
