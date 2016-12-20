using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class GSMTest
    {
        public static void TestGenerator()
        {
            /*TODO default standard and default custom init-s
            (using singleton for setting default fields of custom data) needed OWNER specific ctor

            find solution for default init 
                        GSM[] someGSMs = new GSM[3];*/

            GSM[] someGSMs = new GSM[]
                                 {
                                     new GSM("iPhone","Apple"),
                                     new GSM("Nexus","Google"),
                                     new GSM("Xiomi","PlusOne"),
                                     new GSM("M7","HTC"),
//                                     new GSM("Xiomi","Plusone"),
                                 };

            foreach (var gsm in someGSMs)
            {
                Console.WriteLine(gsm);
            }
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
