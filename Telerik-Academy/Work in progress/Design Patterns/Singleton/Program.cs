using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = SingletonThinking.GetNewInstanceQuickProp;
            s.SomeNumericData += s.SomeNumericData + 10;

            Console.WriteLine(s.SomeNumericData);

            var a = SingletonThinking.GetNewInstanceQuickProp;

            Console.WriteLine(a.SomeNumericData);

            Console.WriteLine(ReferenceEquals(a,s));
        }
    }
}
