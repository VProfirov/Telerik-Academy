using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Contracts;

namespace Dealership.Models.Output
{
    public static class VehiclesOutput
    {
        public static string VehicleGeneralInfo(IVehicle vehicle)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"  Make: {vehicle.Make}");
            sb.AppendLine($"  Model: {vehicle.Model}");
            sb.AppendLine($"  Wheels: {vehicle.Wheels}");
            sb.AppendLine($"  Price: ${vehicle.Price}");
//            sb.AppendLine(this.PrintSpecialInfo());
//TODO: FIX !! Common-Named method
            // VEHICLE TYPE SPECIFIC INFO
            sb.AppendLine(PrintComments(vehicle.Comments));
            return sb.ToString().TrimEnd();
        }

        public static string TruckSpecificInfo(ITruck truck)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"  Weight Capacity: {truck.WeightCapacity}t");
            return sb.ToString().TrimEnd();
        }

        public static string MotorcycleSpecificInfo(IMotorcycle motorcycle)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"  Category: {motorcycle.Category}");
            return sb.ToString().TrimEnd();
        }

        public static string CarSpecificInfo(ICar car)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"  Seats: {car.Seats}");
            return sb.ToString().TrimEnd();
        }

        public static string PrintComments(IList<IComment> comments)
        {
            //TODO: RE-CHECK (comments is a field; this is comments...)
            var builder = new StringBuilder();

            if (comments.Count <= 0)
            {
                builder.AppendLine("    --NO COMMENTS--");
            }
            else
            {
                builder.AppendLine("    --COMMENTS--");
                builder.AppendLine("    ----------");
                builder.AppendLine(comments[0].ToString());

                for (int i = 1; i < comments.Count; i++)
                {
                    builder.AppendLine("    ----------");
                    builder.AppendLine("    ----------");
                    builder.AppendLine(comments[i].ToString());
                }

                builder.AppendLine("    ----------");
                builder.AppendLine("    --COMMENTS--");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
}
