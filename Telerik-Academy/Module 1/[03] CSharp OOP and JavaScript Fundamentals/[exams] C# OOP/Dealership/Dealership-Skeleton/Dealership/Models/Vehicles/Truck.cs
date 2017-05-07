using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Contracts;

namespace Dealership.Models.Vehicles
{
    class Truck:AVehicle,ITruck
    {
        public Truck(string make, string model, decimal price,int weightCapacity) : base(make, model, price)
        {
            this.WeightCapacity = weightCapacity;
        }

        public int WeightCapacity { get; }
    }
}
