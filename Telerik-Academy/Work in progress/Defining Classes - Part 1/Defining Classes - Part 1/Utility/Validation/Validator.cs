using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Defining_Classes___Part_1.Utility.Enums;

namespace Defining_Classes___Part_1.Utility.Validation
{
    public static class Validator
    {
        public static void ValidateManufacturer(string manufacturer)
        {
            var isDefined = Enum.IsDefined(typeof(ManufacturerType), manufacturer);
            if (!isDefined)
            {
                throw new ArgumentException($"{manufacturer} does not exist in our list manufacturers.(ManufacturerType enum)");
            }

        }

        public static void ValidateModel(string model)
        {
            var isDefined = Enum.IsDefined(typeof(ModelType), model);
            if (!isDefined)
            {
                throw new ArgumentException($"{model} does not exist in our list of models.(Model enum)");
            }
        }
        ////TODO:#3.Finish Validation for DisplaySyze&ColorCOunt
        public static void ValidateDisplaySize(double size)
        {
            //valid display size - for mobile

        }

        public static void ValidateDisplayNumberOfColors(int numberOfColors)
        {
            //valid colors count
        }
    }
}
