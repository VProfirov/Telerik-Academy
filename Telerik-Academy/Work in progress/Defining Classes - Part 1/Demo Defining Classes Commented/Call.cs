namespace Demo_Defining_Classes_Commented
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
    }
}




