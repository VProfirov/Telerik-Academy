using System;
using System.Collections.Generic;
using System.Text;
using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using Dealership.Models.Custom_Validator;

namespace Dealership.Models
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
            CustomValidator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);
            if (this.Role == Role.Admin)
            {
                throw new ArgumentException(Constants.AdminCannotAddVehicles);
            }
            else if ((this.Role != Role.VIP) && (this.Vehicles.Count >= Constants.MaxVehiclesToAdd))
            {
                throw new ArgumentException(string.Format(Constants.NotAnVipUserVehiclesAdd, Constants.MaxVehiclesToAdd));

            }
            this.Vehicles.Add(vehicle);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            CustomValidator.ValidateNull(vehicle,Constants.VehicleCannotBeNull);
            this.Vehicles.Remove(vehicle);
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {

            CustomValidator.ValidateNull(commentToAdd, Constants.CommentCannotBeNull);
            CustomValidator.ValidateNull(vehicleToAddComment, Constants.VehicleCannotBeNull);
            
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            CustomValidator.ValidateNull(commentToRemove,Constants.CommentCannotBeNull);
            CustomValidator.ValidateNull(vehicleToRemoveComment,Constants.VehicleCannotBeNull);
            if (commentToRemove.Author != this.Username)
            {
                throw new ArgumentException(Constants.YouAreNotTheAuthor);
            }
            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public string PrintVehicles()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"--USER {Username}--");

            if (Vehicles.Count == 0)
            {
                builder.AppendLine("--NO VEHICLES--");
                return builder.ToString().TrimEnd();
            }

            for (int i = 0; i < Vehicles.Count; i++)
            {
                builder.AppendLine($@"{i + 1}. {Vehicles[i].Type}:");
                builder.AppendLine(Vehicles[i].ToString());
            }
            return builder.ToString().TrimEnd(); ;
        }

        public override string ToString()
        {
            return string.Format(Constants.UserToString,this.Username,this.FirstName,this.LastName,this.Role);
        }
    }
}

//"Username: {Username}, FullName: {FirstName} {LastName}, Role: {Role}"