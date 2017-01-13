using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate IEnumerable<string> StackerIEnum();

    delegate string Stacker();

    class Simple_Delegate
    {
        public IEnumerable<string> QuerryMethod()
        {
            int counter = 0;
            yield return $"Querry Method - {counter++}";
        }
        
    }

    static class StaticSimple_Delegate
    {
        public static IEnumerable<string> QM()
        {
            int counter = 0;
            yield return $"QM - {counter++}";
        }

        public static string QMs()
        {
            return "wtf";
        }
    }
}
