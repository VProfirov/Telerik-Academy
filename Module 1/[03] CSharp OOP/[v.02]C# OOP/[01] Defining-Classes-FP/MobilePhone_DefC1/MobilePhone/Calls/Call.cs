using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone.Calls
{
    class Call
    {
        private DateTime callDateTime;
        private int calledNumber;
        private TimeSpan duration;

//        private Tuple<DateTime, TimeSpan, int> callInfo;
        public Call(int calledNumber)
        {
            this.calledNumber = calledNumber;
            //???
            this.duration = TimeSpan.FromMinutes(5);
            this.callDateTime = DateTime.Now;
        }
    }
}
