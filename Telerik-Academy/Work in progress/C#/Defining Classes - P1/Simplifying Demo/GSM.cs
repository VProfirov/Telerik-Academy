using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplifying_Demo
{
    using System.Data;
    using System.Xml.Schema;

    class GSM
    {
        private readonly ManufacturerType manufacturer;

        private readonly Battery battery;
        private readonly Display display;

        private string owner;
        

        public GSM(string manufacturer,string model)
        {
            Validation(manufacturer, model);
            this.manufacturer = (ManufacturerType)Enum.Parse(typeof(ManufacturerType), manufacturer, true);
        }

        public GSM(string manufacturer,string model,string owner,Battery battery, Display display):this(manufacturer,model)
        {
            this.Owner = owner;
            if (battery == null)
            {
                this.battery = new Battery();
            }
            else
            {
                this.battery = battery;
            }

            if (display == null)
            {
                this.display = new Display();
            }
            else
            {
                this.display = display;
            }
        }
        public ManufacturerType Manufacturer => this.manufacturer;
        public string Owner {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NoNullAllowedException("There has to be a valid name");
                }
                this.owner = value;
            }
        }
        public  Battery Battery { get; }

        public  Display Displa{ get; }

        private static void Validation(string manufacturer, string model)
        {
            Validator.ValidateManufacturer(manufacturer);
            Validator.ValidateModel(model);
        }

    }
}

