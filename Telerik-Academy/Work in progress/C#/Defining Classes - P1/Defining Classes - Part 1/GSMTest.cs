using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class GSMTest
    {
        public static void GSMTestGenerator()
        {
            GSM[] someGSMs = new GSM[]
                                 {
                                     new GSM("Nexus","Google"),
                                     new GSM("PlusOne","Xiomi"),
                                     new GSM("M7","HTC")
                                 };

            foreach (var gsm in someGSMs)
            {
                Console.WriteLine(gsm);
            }
            Console.WriteLine(GSM.IPhone4S);

//            foreach (var gsm in someGSMs)
//            {
//              gsm.AddCall(DateTime.Now, "0001100",TimeSpan.FromMinutes(5));
//            }
        }
    }
}
