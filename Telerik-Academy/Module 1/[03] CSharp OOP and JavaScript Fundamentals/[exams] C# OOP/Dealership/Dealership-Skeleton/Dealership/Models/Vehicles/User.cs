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

            //NO Validation for FirstName and LastName constants available but REQUIRED ?!
            CustomValidator.ValidateStringRange(firstName,Constants.MinNameLength,Constants.MaxNameLength,Constants.StringMustBeBetweenMinAndMax);
            CustomValidator.ValidateStringRange(lastName, Constants.MinNameLength, Constants.MaxNameLength, Constants.StringMustBeBetweenMinAndMax);
            //TODO: NO DIRECT Validation for Role

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


            /*
             If the user is admin he cannot add a vehicle
             If the user is not VIP he cannot add more than 5 vehicles
             */
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
            
            /*Just add the comment to the list*/

            //implemented command using it:
            /*AddComment (content, author, vehicleIndex) - add a comment with the content provided to the vehicle with that index and sets the author*/


            //vehicles.Comments add commentToAdd
            throw new NotImplementedException();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            //Comment Validation

            /*If the author of the comment is not the current user he cannot remove it*/

            //implemented command using it:
            /*RemoveComment (vehicleIndex, commentIndex, username) - removes the comment from the vehicle*/
            throw new NotImplementedException();
        }

        public string PrintVehicles()
        {

            /*
             User
Username: {Username}, FullName: {FirstName} {LastName}, Role: {Role}
             */


            //All vehicles of the user
            /*
--USER {Username}--
1. {Vehicle type}:
  Make: {Make}
  Model: {Model}
  Wheels: {Wheels}
  Price: ${Price}
  Category/Weight capacity/Seats: {Category/Weight capacity/Seats}
    --COMMENTS--
    ----------
    {Content}
      User: {Comment Username}
    ----------
    ----------
    {Content}
      User: {Comment username}
    ----------
    --COMMENTS--
2. {Vehicle type}:
  Make: {Make}
  Model: {Model}
  Wheels: {Wheels}
  Price: ${Price}
  Category/Weight capacity/Seats: {Category/Weight capacity/Seats}
    --NO COMMENTS--
             */

            throw new NotImplementedException();
        }
    }
}
