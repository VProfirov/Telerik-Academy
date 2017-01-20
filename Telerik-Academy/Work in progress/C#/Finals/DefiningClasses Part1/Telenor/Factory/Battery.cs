using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.Factory
{
    using System.Diagnostics.Contracts;

    using Telenor.Factory.Utils;
    using Telenor.Factory.Utils.Validator;
    class Battery
    {
        public Battery_Model BatteryModel { get; } = Battery_Model.undefined;

        public TimeSpan HoursIdle { get; set; } = TimeSpan.Zero;

        public TimeSpan HoursTalk { get; set; } = TimeSpan.Zero;

        public Battery()
        {
            this.BatteryModel = Battery_Model.undefined;
            this.HoursIdle = TimeSpan.Zero;
            this.HoursTalk = TimeSpan.Zero;
        }

        /// <summary>
        /// Specific Battery
        /// </summary>
        /// <para> ctor arg defaulting : TimeSpan hoursTalkSpan = default(TimeSpan)</para>
        /// <param name="model"></param>
        /// <param name="hooursIdleSpan">Probably Used Battery</param>
        /// <param name="hoursTalkSpan">Probably Used Battery</param>
        public Battery(Battery_Model model, TimeSpan hooursIdleSpan,TimeSpan hoursTalkSpan)
        {
            this.BatteryModel = model;
            this.HoursIdle = hooursIdleSpan;
            this.HoursTalk = hoursTalkSpan;
        }
        //TODO: Question Defaulting in the ctor(signiture || body) or property
        public Battery(string model = "undefined", string hooursIdleSpan = "0", string hoursTalkSpan="0")
        {
            //try-catch-finaly will be better
            ValdiateBattery.Model(model);
            this.BatteryModel = (Battery_Model)Enum.Parse(typeof(Battery_Model), model);
            ValdiateBattery.TimeSpan(hooursIdleSpan);
            this.HoursIdle = TimeSpan.Parse(hooursIdleSpan);
            ValdiateBattery.TimeSpan(hoursTalkSpan);
            this.HoursTalk = TimeSpan.Parse(hoursTalkSpan);
        }
        public override string ToString()
        {
            return base.ToString();// to be implemented
        }

        /// <summary>
        /// Built-in Generic/String/ Dynamyc
        /// [if all the parameters are 'optional'=> type name = default] Parsing for A Constructor
        /// </summary>
        /// <para> Reflection or/and try-catch-finaly needed to add the *validation*?* and make a dynamic composition possible [use what is valid, init default the rest]</para>
        /// <param name="model"></param>
        /// <param name="hoursIdle"></param>
        /// <param name="hoursTalk"></param>
        /// <param name="battery"></param>
        /// <returns></returns>
        public static bool TryParseConstructor(string model, string hoursIdle, string hoursTalk,out Battery battery)
        {
            throw new NotImplementedException();
        }
        
    }
}
