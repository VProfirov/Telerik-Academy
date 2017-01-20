using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.Factory
{
    using Telenor.Factory.Utils;
    using Telenor.Factory.Utils.Enums;
    using Telenor.Factory.Utils.Validators;

    class Battery
    {
        public Battery_Model_Type BatteryModelType { get; } = Battery_Model_Type.undefined;

        public TimeSpan HoursIdle { get; set; } = TimeSpan.Zero;

        public TimeSpan HoursTalk { get; set; } = TimeSpan.Zero;

        public Battery()
        {
            this.BatteryModelType = Battery_Model_Type.undefined;
            this.HoursIdle = TimeSpan.Zero;
            this.HoursTalk = TimeSpan.Zero;
        }

        /// <summary>
        /// Specific Battery
        /// </summary>
        /// <para> ctor arg defaulting : TimeSpan hoursTalkSpan = default(TimeSpan)</para>
        /// <param name="modelType"></param>
        /// <param name="hooursIdleSpan">Probably Used Battery</param>
        /// <param name="hoursTalkSpan">Probably Used Battery</param>
        public Battery(Battery_Model_Type modelType, TimeSpan hooursIdleSpan,TimeSpan hoursTalkSpan)
        {
            this.BatteryModelType = modelType;
            this.HoursIdle = hooursIdleSpan;
            this.HoursTalk = hoursTalkSpan;
        }
        //TODO: Question Defaulting in the ctor(signiture || body) or property
        public Battery(string model = "undefined", string hooursIdleSpan = "0", string hoursTalkSpan="0")
        {
            //try-catch-finaly will be better
            ValdiateBattery.Model(model);
            this.BatteryModelType = (Battery_Model_Type)Enum.Parse(typeof(Battery_Model_Type), model);
            ValdiateBattery.TimeSpan(hooursIdleSpan);
            this.HoursIdle = TimeSpan.Parse(hooursIdleSpan);
            ValdiateBattery.TimeSpan(hoursTalkSpan);
            this.HoursTalk = TimeSpan.Parse(hoursTalkSpan);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('_', 30));
            sb.AppendLine($"[Battery Info]");
            sb.AppendLine($"Battery's Model: ");
            sb.AppendLine($"Battery's Hours Idle: ");
            sb.AppendLine($"Battery's Hours Talked:");
            sb.AppendLine(new string('_', 30));
            var message = sb.ToString();
            return message;// to be implemented
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
