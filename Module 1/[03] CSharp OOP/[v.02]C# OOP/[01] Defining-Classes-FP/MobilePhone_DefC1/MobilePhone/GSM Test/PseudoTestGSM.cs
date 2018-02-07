using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone.GSM_Test
{
    using GSM;
    public static class PseudoTestGSM
    {
        private static List<GSM> gsmArr = new List<GSM>()
        {
            new GSM("htc m9","HTC"),
            new GSM("Samsung Galaxy S7","Samsung"),
            new GSM("Nexus One","Google")
        };

        public static void DisplayGSMsInfo()
        {
            foreach (var gsm in gsmArr)
            {
                Console.WriteLine(gsm);
            }
        }

        public static void DisplayIPhone4sInfo()
        {
            Console.WriteLine(GSM.iPhone4S);
        }
    }
}
