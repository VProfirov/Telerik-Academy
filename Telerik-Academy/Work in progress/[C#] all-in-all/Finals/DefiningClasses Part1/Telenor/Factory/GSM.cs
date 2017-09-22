using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.Factory
{
    using System.Net.Http;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;

    using Telenor.Factory.Functionality;
    using Telenor.Factory.Utils;
    using Telenor.Factory.Utils.Validators;
    using Telenor.UnitTests;

    class GSM
    {
        private static GSM _iPhone4s = new GSM("iPhone4S", "Apple");
        //explicit props
        public static GSM iPhone4s {
            get
            {
                return _iPhone4s;
            }
        }

        public List<Call> CallHistory { get; set; } = new List<Call>();

        //implicit props
        public string Model { get; private set; } = "undefined";

        public string Manufacturer { get; private set; } = "undefined";

        public decimal Price { get; private set; } = 0m;

        public string Owner { get; private set; } = "undefined";

        public Battery Battery { get; private set; } = new Battery();

        public Display Display { get; private set; } = new Display();

        //ctors
        
        public GSM(string model, string manufacturer)
        {
            this.Model = model; //prop validation VS external [ValidationGSM] ...
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price, string owner):this(model,manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
        }
        public GSM(string model,string manufacturer,decimal price,string owner,Battery battery, Display display):this(model,manufacturer,price,owner)
        {
            this.Battery = battery;
            this.Display = display;
        }
        //methods... TODO: Does it need a Visualizer for the ToString ?
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($@"GSM's Information:");
            sb.AppendLine($@"GSM Model: {this.Model}");
            sb.AppendLine($@"GSM Manufacturer: {this.Manufacturer}");
            sb.AppendLine($@"Price: {this.Price}");
            sb.AppendLine($@"Current Owner: {this.Owner}");
            sb.AppendLine();

            sb.AppendFormat("{0}Specifications{0} \r\n", new string(' ',6));
            sb.AppendLine($@"{this.Battery}");
            sb.AppendLine($@"{this.Display}");
            sb.AppendLine();

            var message = sb.ToString();
            return message;
        }

        public void AddCall(string oppositeNumber)
        {
            Call nextCall = new Call(oppositeNumber);
            CallHistory.Add(nextCall);
        }

        public void DeleteCall(object target)
        {
            try
            {
                ////remove by [position; phone number]
                if ((target is int) && ((int)target <= CallHistory.Count && (int)target > 0))
                {
                    CallHistory.RemoveAt((int)target);
                }
                else if ((target is string) && 
                    Regex.Match((string)target, @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$")
                         .Success)
                {
                    for (int i = 0; i < CallHistory.Count; i++)
                    {
                        if (CallHistory[i].PhoneNumber == (string)target)
                        {
                            CallHistory.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                
                throw new ArgumentException("The target is neither call at position, neither a phone number\r\n",e);
            }
           
        }
        
        public decimal CallPrice()
        {
            throw new NotImplementedException("calculates the total price of the calls in the call history.");
        }
    }
}
