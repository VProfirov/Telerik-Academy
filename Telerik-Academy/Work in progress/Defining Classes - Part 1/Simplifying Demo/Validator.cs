using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplifying_Demo
{
    using System.ComponentModel;

    class Validator
    {
        public static void ValidateModel(string model)
        {
            if (!Enum.IsDefined(typeof(ModelType),model))
            {
                throw new InvalidEnumArgumentException($"{model} is not acceptable Model Type");
            }
        }

        public static void ValidateManufacturer(string manufacturer)
        {
            if (!Enum.IsDefined(typeof(ManufacturerType), manufacturer))
            {
                throw new InvalidEnumArgumentException($"{manufacturer} is not acceptable Model Type");
            }
        }
    }
}
