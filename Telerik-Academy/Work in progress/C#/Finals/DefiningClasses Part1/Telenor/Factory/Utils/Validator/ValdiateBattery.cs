using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telenor.Factory.Utils;
namespace Telenor.Factory.Utils.Validator
{
    //consider abastract class with static methods || static class [extenion class || constant based class (static)]
    internal abstract class ValdiateBattery
    {
      
        internal static void Model(string model)
        {
            bool isFound = false;
            string[] allModels = Enum.GetNames(typeof(Battery_Model));
            foreach (var m in allModels)
            {
                if (string.Compare(model, m, true) == 0)
                {
                    isFound = true;
                }
            }
            if (!isFound)
            {
                throw new ArgumentException($@"The is no ""{ model }""");
            }
        }

        internal static void TimeSpan(string timespan)
        {
            long span;
            bool isParsable = long.TryParse(timespan, out span);
            if (isParsable)
            {
                if (span < 0)
                {
                    throw new ArgumentException($@"The Time Span ({timespan}) must be 0 or POSITIVE !");
                }
            }
        }
    }
}
