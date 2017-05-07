using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Contracts;

namespace Dealership.Models.Vehicles
{
    class Motorcycle:AVehicle,IMotorcycle
    {
        public Motorcycle(string make, string model, decimal price, string category) : base(make, model, price)
        {
            this.Category = category;
        }
        public string Category { get; }
    }
}
