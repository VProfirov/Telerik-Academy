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
    class Car:AVehicle,ICar
    {
        public Car(string make,string model,decimal price, int seats):base(make,model,price)
        {
            CustomValidator.ValidateIntRange(seats,Constants.MinSeats,Constants.MaxSeats,Constants.NumberMustBeBetweenMinAndMax);
            this.Seats = seats;
        }
        public int Seats { get; }
    }
}
