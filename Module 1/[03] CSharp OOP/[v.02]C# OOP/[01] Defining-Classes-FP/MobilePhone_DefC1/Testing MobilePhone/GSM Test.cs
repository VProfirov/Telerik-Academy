using System;
using System.Collections.Generic;
using Xunit;

namespace Testing_MobilePhone
{
    using MobilePhone.GSM;
    public class GSM_Test
    {
        public List<GSM> gsmArr = new List<GSM>()
        {
            new GSM("htc m9","HTC"),
            new GSM("Samsung Galaxy S7","Samsung"),
            new GSM("Nexus One","Google")
        };
        [Fact]
        public void GSMs_InfoDisplay()
        {
            //arrange  act assert
            

            foreach (var gsm in gsmArr)
            {
                Console.WriteLine(gsm);
            }

            //assert

            // ??????
        }

        [Fact]
        public void GSMs_Static_iPhone4s()
        {
            //arrange  act assert

            Console.WriteLine(GSM.iPhone4S);

            //assert
        }
    }
}
