using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone.Calls
{
    class Calls
    {
        private List<DateTime> callHistory;
        private int callNumberl;
        private TimeSpan duration;

        private Tuple<DateTime, TimeSpan, int> callInfo;
    }
}
