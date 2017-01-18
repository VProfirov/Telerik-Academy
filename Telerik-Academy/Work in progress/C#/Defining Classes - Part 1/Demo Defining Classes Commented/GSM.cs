using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Demo_Defining_Classes_Commented.Utility.Enums;
using Demo_Defining_Classes_Commented.Utility.Validation;

namespace Demo_Defining_Classes_Commented
{
    using System.Runtime.CompilerServices;

    class GSM
    {
        private Display display;
        private Battery battery;
        private List<Call> callHistory;
        //requires Utility class with static methods for validation
        private readonly ManufacturerType manufacturer;
        private readonly ModelType model;
        //passed as a string and used as a type (ManufacturerType)Enum.Parse(typeof(ManufacturerType),value)
        
            /// <summary>
            /// Using auto implemented Properties instead
            /// </summary>
//        private decimal price;
//        private string owner;

        private static readonly GSM iPhone4S = new GSM("iPhone","Apple",999);
        
        //if unknown fill = null --- decimal?
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

            //TODO when should we check in a ctor/class so that we dont break the Single Responsibility Principle
        }

        public GSM(string model,string manufacturer,decimal? price) : this(model, manufacturer, price, null,null, null)
        {
              
        }
        // no null handling at DISPLAY & Battery
        public GSM(string model, string manufacturer)
        {
            this.manufacturer = (ManufacturerType) Enum.Parse(typeof(ManufacturerType), manufacturer);
            this.model = (ModelType) Enum.Parse(typeof(ModelType), model);
        }
        ////TODO:[?]1.UPwards vs DOWNwards SubChain ctors {thesis : DOWNWARDS ctors with external abstraction for AN AUTOGENERATOR}
        ////TODO:/VS/static ctor that initializes it all ?
        ////TODO:/VS/static Properties to initialize it all on demand (#region Example)? {with a check if it is already init-ed}
        
        ////prop with expression body
        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        ////TODO:#2.Finish Calls and CallHistory
        public List<Call> CallHistory { get; set; }

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
                if (!(value.Size >= 7 && value.Size <= 12))
                {
                    throw new ArgumentException($"We don't support {value.Size}, only 10 to 32 inch");
                }
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
                if (!(value.BatteryModel is BatteryType))
                {
                    throw new ArgumentException($"We don't support {value.BatteryModel}");
                }
                this.battery = value;
            }
        }

        //generator for Call
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

        public static decimal CalculateCallBill()
        {
            return 5; // pricepermin is fixed
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

        ////isn't this some kind of loop calling? static field ?cant have properties with setter
        //// TODO:#5.Check the deal of static properties [DONE-fix comment]
      
        public override string ToString()
        {
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