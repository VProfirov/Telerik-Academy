namespace Telenor.UnitTests
{
    using System;
    using System.Collections.Generic;

    using Telenor.Factory;
    using Telenor.Factory.Offers;
    using Telenor.Factory.Utils.Enums;

    class GSMTest
    {
        private static readonly List<GSM> testSomeGSMs = new List<GSM>
        {
            new GSM("Nexus", "Google"),
            new GSM("One M9", "HTC"),
            new GSM("Nexus", "Google",105.5m,"Pesho",new Battery(Battery_Model_Type.Li_Ion, TimeSpan.FromHours(1), TimeSpan.FromHours(5)),new Display("24","256") ),
              new GSM("One M7", "HTC", 200m,"Gosho")
        };

        public static void Ouput()
        {
            foreach (var gsm in testSomeGSMs)
            {
                Console.WriteLine(gsm);   
            }

            GSM_Offers.ShowSpecialOffers();
        }
    }
}