using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Defining_Classes___Part_1.Utility.Enums;

namespace Defining_Classes___Part_1
{
    using System.Runtime.Remoting.Channels;

    using Defining_Classes___Part_1.Utility.Validation;

    class GSM
    {
        private Display display;
        private Battery battery;
        private Call callHistory;
        //requires Utility class with static methods for validation
        private readonly ManufacturerType manufacturer;
        private readonly ModelType model;
        //passed as a string and used as a type (ManufacturerType)Enum.Parse(typeof(ManufacturerType),value)

            /// <summary>
            /// Using auto implemented Properties instead
            /// </summary>
//        private decimal price;
//        private string owner;

        private static string iPone4S;
        
        //if unknown fill = null
        public GSM(string model, string manufacturer, decimal price, string owner, Display display, Battery battery)
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
        ////TODO:#1.SubChain ctors

        ////prop with expression body
        public ModelType Model => this.model;

        public ManufacturerType Manufacturer => this.manufacturer;

        #region EncapsulatedFields
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
                if (!(value.Type is BatteryType))
                {
                    throw new ArgumentException($"We don't support {value.Type}");
                }
                this.battery = value;
            }
        }

        public decimal Price { get; set; }

        public string Owner { get; set; }

        #endregion
        ////TODO:#2.Finish Calls and CallHistory
        public List<Call> CallHistory { get; set; }

        ////isn't this some kind of loop calling? static field ?cant have properties with setter
        //// TODO:#5.Check the deal of static properties
        public static string iPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                iPhone4S = value;
            }
        }


        public override string ToString()
        {
            ////string interpolation expression
            var message = $"The Model of the GSM is : {this.model}";
            return message;
        }

        public static void Validation(string model,string manufacturer)
        {
            Validator.ValidateModel(model);
            Validator.ValidateManufacturer(manufacturer);
        }
    }
}
