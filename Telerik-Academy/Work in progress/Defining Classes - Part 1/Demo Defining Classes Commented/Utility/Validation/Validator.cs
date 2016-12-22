using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Defining_Classes_Commented.Utility.Enums;

namespace Demo_Defining_Classes_Commented.Utility.Validation
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
        public static void ValidateDisplaySize(double? size)
        {
            if (size != null || size < 0)
            {
                throw new ArgumentException("Display Size can't be negative");
            }

        }

        public static void ValidateDisplayNumberOfColors(int? numberOfColors)
        {
            if (numberOfColors != null || numberOfColors < 0)
            {
                throw new ArgumentException("The Number of Colors to a Display can't be negative");
            }
        }
    }
}
