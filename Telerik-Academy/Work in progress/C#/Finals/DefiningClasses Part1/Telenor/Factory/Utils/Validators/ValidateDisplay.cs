using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.Factory.Utils.Validators
{
    class ValidateDisplay
    {
        public static double DisplaySize(string size)
        {
            double result;
            if (double.TryParse(size,out result) && (result>=0))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($@"[{size}] is not a valid for Display Size in inches of type double");
            }
        }

        public static int NumberOfColors(string numberOfColors)
        {
            int result;
            if (int.TryParse(numberOfColors, out result) && (result >= 0))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($@"[{numberOfColors}] is not a valid for Display Size in inches of type double");
            }
        }

        // rethink with Generic Type Validation - [SOLID] DRY
    }
}
