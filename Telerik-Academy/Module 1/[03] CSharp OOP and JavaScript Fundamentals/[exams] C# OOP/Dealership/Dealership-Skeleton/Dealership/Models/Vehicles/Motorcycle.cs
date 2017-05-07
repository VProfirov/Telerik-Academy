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
    class Motorcycle:AVehicle,IMotorcycle
    {
        public Motorcycle(string make, string model, decimal price, string category) : base(make, model, price)
        {
            CustomValidator.ValidateStringRange(category,Constants.MinCategoryLength,Constants.MaxCategoryLength,Constants.NumberMustBeBetweenMinAndMax);
            this.Category = category;
        }
        public string Category { get; }
    }
}
