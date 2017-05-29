using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using Dealership.Models.Custom_Validator;

namespace Dealership.Models.Vehicles
{
    abstract class AVehicle:IVehicle
    {
        private readonly int _wheels;

        protected AVehicle(string make, string model, decimal price)
        {
            CustomValidator.ValidateStringRange(make,Constants.MinMakeLength,Constants.MaxMakeLength,Constants.StringMustBeBetweenMinAndMax);
            CustomValidator.ValidateStringRange(model, Constants.MinModelLength, Constants.MaxModelLength, Constants.StringMustBeBetweenMinAndMax);
            CustomValidator.ValidateDecimalRange(price,Constants.MinPrice,Constants.MaxPrice,Constants.NumberMustBeBetweenMinAndMax);
            this.Make = make;
            this.Model = model;
            this.Price = price;

            this.Type = (VehicleType)Enum.Parse(typeof(VehicleType), this.GetType().Name);

            //TODO: The Wheels Constant for Validation IS used! But does a redundant or out of place validation.
            CustomValidator.ValidateIntRange((int)this.Type,Constants.MinWheels,Constants.MaxWheels,Constants.NumberMustBeBetweenMinAndMax);
            this.Wheels = (int)this.Type;
        }
        public IList<IComment> Comments { get; } = new List<IComment>();
        public decimal Price { get; }
        public int Wheels { get; }
        public VehicleType Type { get; }
        public string Make { get; }
        public string Model { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"  Make: {Make}");
            sb.AppendLine($"  Model: {Model}");
            sb.AppendLine($"  Wheels: {Wheels}");
            sb.AppendLine($"  Price: ${Price}");
            return sb.ToString().TrimEnd();
        }
    }
}
