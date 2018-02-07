using System;
using System.Collections.Generic;
using Xunit;

namespace Testing_MobilePhone
{
    using MobilePhone.GSM;
    public class UnitTest1
    {
        [Fact]
        public void GSMs_InfoDisplay()
        {
            //arrange  act assert
            var gsmArr = new List<GSM>();
            gsmArr.Add(new GSM("htc m9", "HTC"));
            gsmArr.Add(new GSM("Samsung Galaxy S7", "Samsung"));
            gsmArr.Add(new GSM("Nexus One", "Google"));

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
            var gsmArr = new List<GSM>();
            gsmArr.Add(new GSM("htc m9","HTC"));
            gsmArr.Add(new GSM("Samsung Galaxy S7","Samsung"));
            gsmArr.Add(new GSM("Nexus One","Google"));

            Console.WriteLine(GSM.iPhone4S);

            //assert
        }
    }
}
