using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common;
using Dealership.Contracts;
using Dealership.Models.Custom_Validator;

namespace Dealership.Models.Vehicles
{
    class Truck:AVehicle,ITruck
    {
        public Truck(string make, string model, decimal price,int weightCapacity) : base(make, model, price)
        {
            CustomValidator.ValidateIntRange(weightCapacity,Constants.MinCapacity,Constants.MaxCapacity,Constants.NumberMustBeBetweenMinAndMax);
            this.WeightCapacity = weightCapacity;
        }

        public int WeightCapacity { get; }
    }
}
