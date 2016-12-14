using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class Battery
    {
        public readonly BatteryType type;

        private TimeSpan hoursIdle;

        private TimeSpan hoursTalk;

        public BatteryType Type { get; set; }

        public TimeSpan HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public TimeSpan HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("_____Battery Status_____");
            message.AppendFormat("Battery type: {0}",this.type);
            message.AppendFormat("Hours idle: {0}", this.hoursIdle);
            message.AppendFormat("Hours talked: {0}", this.hoursTalk);
            message.AppendLine("________________________");
            return base.ToString();
        }
    }
}
