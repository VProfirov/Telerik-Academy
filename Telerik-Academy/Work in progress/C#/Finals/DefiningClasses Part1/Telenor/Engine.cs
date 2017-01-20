using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor
{
    using System.Diagnostics.CodeAnalysis;

    using Telenor.Factory.Utils;
    using Telenor.UnitTests;

    class Engine
    {
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
        public static void Main()
        {
            GSMTest.Ouput();
            GSMCallHistoryTest.MakeCallTest();
        }
    }
}
