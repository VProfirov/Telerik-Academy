using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telenor.Factory.Utils;
namespace Telenor.Factory.Utils.Validator
{
    //consider abastract class with static methods
    internal static class ValdiateBattery
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

        internal static void HoursIdle(string hoursIdle)
        {
        }

        internal static void HoursTalk(string hoursTalk)
        {

        }
    }
}
