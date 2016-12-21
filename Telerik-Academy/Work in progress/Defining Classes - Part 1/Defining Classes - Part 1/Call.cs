namespace Defining_Classes___Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Call
    {
        public Call(DateTime dateAndTime, string dialedNumber, TimeSpan duration)
        {
            this.DateTime = dateAndTime;
            this.DialedNumber = dialedNumber;
////           this.DialedNumbers.Add(dialedNumber);
            this.DurationInSec = duration;
        }

        public DateTime DateTime { get; private set; }

        public string DialedNumber { get; private set; }
////      public List<string> DialedNumber { get; private set; }


        public TimeSpan DurationInSec { get; private set; }

        public override string ToString()
        {
            //TODO refactor +++ in gsm cuz of the CALLHISTOR LIST ???
            StringBuilder callHist = new StringBuilder();
            callHist.AppendLine("CALL HISTORY:");
            Console.WriteLine("---------------------------------");
            foreach (var call in CallHistory)
            {
                callHist.AppendFormat("Number: {0},  Date: {1},  Duration: {2} \n", call.DialedNumber, call.DateTime, call.DurationInSec);
            }

            Console.WriteLine("---------------------------------");

            Console.WriteLine(callHist.ToString());
        }
    }
}




