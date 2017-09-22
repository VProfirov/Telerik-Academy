using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Defining_Classes___Part_1.Utility.Enums;
using Defining_Classes___Part_1.Utility.Validation;

namespace Defining_Classes___Part_1
{
    using System.Runtime.CompilerServices;

    class GSM
    {
        private Display display;
        private Battery battery;
        private List<Call> callHistory;

        private readonly ManufacturerType manufacturer;
        private readonly ModelType model;

        private static readonly GSM iPhone4S = new GSM("iPhone","Apple",999);
       

        public GSM(string model, string manufacturer, decimal? price, string owner, Display display, Battery battery)
        {
            this.Display = display;
            this.Battery = battery;
            ////usualy validates this.values directly after constructing/init-ing [check Display.ctor.comments]
            Validation(model, manufacturer);
            this.manufacturer = (ManufacturerType)Enum.Parse(typeof(ManufacturerType), manufacturer);
            this.model = (ModelType)Enum.Parse(typeof(ModelType), model);

            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model,string manufacturer,decimal? price) : this(model, manufacturer, price, null,null, null)
        {
              
        }
        // no null handling at DISPLAY & Battery
        public GSM(string model, string manufacturer):this(model,manufacturer,null,null,null,null)
        {
           
        }
        ////TODO:[?]1.UPwards vs DOWNwards SubChain ctors {thesis : DOWNWARDS ctors with external abstraction for AN AUTOGENERATOR}
        ////TODO:/VS/static ctor that initializes it all ?
        ////TODO:/VS/static Properties to initialize it all on demand (#region Example)? {with a check if it is already init-ed}
        
        ////Properties
        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        ////TODO:#2.Finish Calls and CallHistory
        public List<Call> CallHistory {
            get
            {
                return this.callHistory;
            }
        }

        public ModelType Model => this.model;

        public ManufacturerType Manufacturer => this.manufacturer;

        public decimal? Price { get; set; } // TODO validate

        public string Owner { get; set; } // TODO validate

        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                ////valid display size supported from the GSM Brands (in inches)
//                if (!(value.Size >= 7 && value.Size <= 12))
//                {
//                    throw new ArgumentException($"We don't support {value.Size}, only 10 to 32 inch");
//                }
                this.display = value;
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
                //// valid battery types for this GSM Brands
//                if (!(value.BatteryModel is BatteryType))
//                {
//                    throw new ArgumentException($"We don't support {value.BatteryModel}");
//                }
                this.battery = value;
            }
        }

        //Methods
        public void AddCall(DateTime now, string number, TimeSpan duration)
        {
            Call myCall = new Call(now, number, duration);
            CallHistory.Add(myCall);
        }

        public void DeleteCalls(string number) // by Number /Name / Duration
        {
            for (int i = 0; i < CallHistory.Count(); i++)
            {
                if (CallHistory[i].DialedNumber == number)
                {
                    CallHistory.RemoveAt(i);
                    i--; // not to jump over the next value when re-indexed
                }
            }
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public decimal CalculateCallBill()
        {
            decimal callBill = 0;
            foreach (var call in this.CallHistory)
            {
                callBill += call.DurationInSec.Seconds * 0.05M;
            }
            return callBill; // pricepermin is fixed
        }

        public string PrintCallHistory()
        {
            StringBuilder callPrint = new StringBuilder();
            callPrint.AppendLine("____________CALL HISTORY____________");
            foreach (var call in CallHistory)
            {
                callPrint.AppendLine($"Number: {call.DialedNumber},  Date: {call.DateTime},  Duration: {call.DurationInSec}");
            }
            callPrint.AppendLine("__________________________________");

            var message = callPrint.ToString();
            return message;
        }    
      
        public override string ToString()
        {
//            var undef = "UNDEFINEd";
            var builder = new StringBuilder();
            ////string interpolation expression
            builder.AppendLine($"{this.Model} from {this.Manufacturer} is currently priced at {this.Price}");
            builder.AppendLine($"Other characteristics are: {this.Battery} - battery, and {this.Display} - display.");
            builder.AppendLine($"The Current owner is {this.Owner}");
            
            var message = builder.ToString();
            return message;
        }

        public static void Validation(string model,string manufacturer)
        {
            Validator.ValidateModel(model);
            Validator.ValidateManufacturer(manufacturer);
        }
    }
}
// example : https://msdn.microsoft.com/en-us/library/w86s7x04.aspx