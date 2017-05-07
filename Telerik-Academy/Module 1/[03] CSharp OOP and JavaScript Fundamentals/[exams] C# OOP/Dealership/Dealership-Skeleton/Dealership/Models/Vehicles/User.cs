using System;
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
    class User:IUser
    {
        public User(string username,string firstName,string lastName,string password,string role)
        {
            CustomValidator.ValidateSymbols(username,Constants.UsernamePattern,Constants.InvalidSymbols);
            CustomValidator.ValidateStringRange(username,Constants.MinNameLength,Constants.MaxNameLength,Constants.StringMustBeBetweenMinAndMax);
            
            CustomValidator.ValidateSymbols(password,Constants.PasswordPattern,Constants.InvalidSymbols);
            CustomValidator.ValidateStringRange(password,Constants.MinPasswordLength,Constants.MaxPasswordLength,Constants.StringMustBeBetweenMinAndMax);
            //All readonly validation up ! <--

            //NO Validation for FirstName and LastName
            //NO DIRECT Validation for Role

            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = (Role) Enum.Parse(typeof(Role), role);
        }
        public string Username { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Password { get; }
        public Role Role { get; }
        public IList<IVehicle> Vehicles { get; } = new List<IVehicle>();
        public void AddVehicle(IVehicle vehicle)
        {
            //Vehicle Validation

            this.Vehicles.Add(vehicle);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            //Vehicle Validation

            this.Vehicles.Remove(vehicle);
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            //Comment Validation

            //vehicles.Comments add commentToAdd
            throw new NotImplementedException();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            //Comment Validation

            throw new NotImplementedException();
        }

        public string PrintVehicles()
        {
            throw new NotImplementedException();
        }
    }
}
