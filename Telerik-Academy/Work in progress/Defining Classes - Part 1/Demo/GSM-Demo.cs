using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    using System.Runtime.CompilerServices;

    class GSM_Demo
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public Battery Battery = new Battery();
        public Display Display = new Display();

        public GSM_Demo(string model, string manufacturer, int price, Battery battery,Display display)
        {
            model = Model;

            //[не] променлива = пропърти [a обратното]
            //            manufacturer = Manufacturer;
            this.Manufacturer = manufacturer;

            this.Price = price;
            this.Battery = battery;
            this.Display = display;
        }

        public GSM_Demo(string model, string manufacturer, int price): this(model, manufacturer, price, battery, display)
        {

        }

        public string Type { get; set; } = "hi";
        private GSM_Demo(string model)
        {

        }
    }
}