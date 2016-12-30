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
        public static string SomsSTATICstring = "WTF";

        public readonly string SomeREADONLYstring = "READONLY wtf";


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

        public GSM_Demo(string model, string manufacturer, int price): this(model, manufacturer, price,null,null)
        {

        }

        public GSM_Demo()
        {
            
        }

        public string Type { get; set; } = "hi";
      

        public string AssPROP { 
            get
            {
                //this acts as DEFAULT setting - as can be done at the ctor
                return SomsSTATICstring = "ass";
            }
            set
            {
                SomsSTATICstring = value;
            }
        }

        // example of use setting a "template data" to be used in the class
        public static string AssStaticPROP
        {
            get
            {
                return SomsSTATICstring = "ASSPROP :D";
            }
            set
            {
                SomsSTATICstring = value;
            }
        }
    }
}