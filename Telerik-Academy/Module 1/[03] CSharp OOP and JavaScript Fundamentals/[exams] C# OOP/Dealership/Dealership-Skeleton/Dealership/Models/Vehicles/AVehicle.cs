using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models.Vehicles
{
    abstract class AVehicle:IVehicle
    {
        protected AVehicle(string make, string model, decimal price)
        {
            
        }
        public IList<IComment> Comments { get; }
        public decimal Price { get; }
        public int Wheels { get; }
        public VehicleType Type { get; }
        public string Make { get; }
        public string Model { get; }
    }
}
