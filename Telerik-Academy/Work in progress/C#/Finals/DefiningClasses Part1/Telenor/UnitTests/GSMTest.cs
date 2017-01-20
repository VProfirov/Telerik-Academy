namespace Telenor.UnitTests
{
    using System;
    using System.Collections.Generic;

    using Telenor.Factory;

    class GSMTest
    {
        private static readonly List<GSM> testSomeGSMs = new List<GSM>
                                             {
                                                 new GSM("iPhone6S", "Apple"),
                                                 new GSM("iPhone6S", "Apple")
                                             };

        public static void Ouput()
        {
            foreach (var gsm in testSomeGSMs)
            {
                Console.WriteLine(gsm);   
            }
        }
    }
}