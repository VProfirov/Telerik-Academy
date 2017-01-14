using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization.Formatters;

    class Engine
    {
        static void Main(string[] args)
        {
            Simple_Delegate sd = new Simple_Delegate();
            sd.QuerryMethod();
            sd.QuerryMethod();


            StaticSimple_Delegate ssd = new StaticSimple_Delegate();
//            IEnumStringStacker iesStack = sd.QuerryMethod();
        }
    }
}
