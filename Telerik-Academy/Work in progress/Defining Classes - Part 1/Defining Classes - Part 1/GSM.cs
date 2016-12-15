using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class GSM
    {
        private Display display;
        private Battery battery;
        private Call callHistory;

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        private static string iPone4S;
//if unknown fill = null
        public GSM(string model, string manufacturer, decimal price, string owner, Display display, Battery battery)
        {
            this.Display = display;
        }


        public string Model { get; private set; }

        #region EncapsulateFields
        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                if (true)//size in borders
                {
                    this.display = value;
                }
                
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            private set
            {
                if (value.Type is BatteryType)
                {
                    this.battery = value;
                }
            }
        }
        #endregion
        public List<Call> CallHistory { get; set; }

        public static string iPhone { get; set; }

        public override string ToString()
        {
            var message = string.Format("The Model of the GSM is : {0}", this.model);
            return message;
        }
    }
}
