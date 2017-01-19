using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.Factory
{
    using Telenor.Factory.Utils;
    using Telenor.Factory.Utils.Validator;
    class Battery
    {
        public Battery_Model BatteryModel { get; }

        public TimeSpan HoursIdle { get; set; }

        public TimeSpan HoursTalk { get; set; }

        public Battery()
        {
            this.BatteryModel = Battery_Model.undefined;
            this.HoursIdle = TimeSpan.Zero;
            this.HoursTalk = TimeSpan.Zero;
        }

        public Battery(Battery_Model model, TimeSpan hooursIdleSpan,TimeSpan hoursTalkSpan)
        {
            this.BatteryModel = model;
            this.HoursIdle = hooursIdleSpan;
            this.HoursTalk = hoursTalkSpan;
            // there should be no hoursIdleSpan & hoursTalkSpan in the ctor - only props
            //props accessible for the gsm to make a call

            //GSM will affect them - and rethink the validation process

        }
        public Battery(string model, string hooursIdleSpan, string hoursTalkSpan)
        {
            //try-catch-finaly will be better
            ValdiateBattery.Model(model);
            this.BatteryModel = (Battery_Model)Enum.Parse(typeof(Battery_Model), model);
            ValdiateBattery.HoursIdle(hooursIdleSpan);
            this.HoursIdle = TimeSpan.Parse(hooursIdleSpan);
            ValdiateBattery.HoursTalk(hoursTalkSpan);
            this.HoursTalk = TimeSpan.Parse(hoursTalkSpan);
            //TimeSpan, because can be 1.5 hours
        }
        public override string ToString()
        {
            return base.ToString();// to be implemented
        }

        public static bool TryParseConstructor(string model, string hoursIdle, string hoursTalk,out Battery battery)
        {
            //have to be checked against a DataBase

            // reflection || try-catch-finaly needed to add the *validation*?* and make a dynamic composition possible [use what is valid]

            throw new NotImplementedException();
        }
        
    }
}
