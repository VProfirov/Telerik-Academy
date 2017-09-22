using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Defining_Classes___Part_1.Utility.Enums;
namespace Defining_Classes___Part_1
{
    class Battery
    {
        ////TODO:#4.CTORs !! ... readonly Enum Types ?
        private BatteryType batteryModel;

        private TimeSpan hoursIdle;

        private TimeSpan hoursTalk;

        public Battery(BatteryType batteryModel,TimeSpan? hoursIdle,TimeSpan? hoursTalk)
        {

        }
        public Battery(BatteryType batteryModel):this(batteryModel, null, null)
        {
         
        }

        public BatteryType BatteryModel
        {
            get{return this.batteryModel;}
            set{this.batteryModel = value;}
        }

        public TimeSpan HoursIdle
        {
            get{return this.hoursIdle;}
            set{this.hoursIdle = value;}
        }

        public TimeSpan HoursTalk
        {
            get{return this.hoursTalk;}
            set{this.hoursTalk = value;}
        }

        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("_____Battery Status_____");
            message.AppendFormat("Battery: {0}",this.BatteryModel);
            message.AppendFormat("Hours idle: {0}", this.HoursIdle);
            message.AppendFormat("Hours talked: {0}", this.HoursTalk);
            message.AppendLine("________________________");
            return base.ToString();
        }
    }
}
