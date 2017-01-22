namespace Telenor.Factory.Utils.Validators
{
    using System;

    using Telenor.Factory.Utils;
    using Telenor.Factory.Utils.Enums;

    //consider abastract class with static methods || static class [extenion class || constant based class (static)]
    internal abstract class ValdiateBattery
    {

        internal static void Model(string model)
        {
            if (!string.IsNullOrEmpty(model))
            {
                bool isFound = false;
                string[] allModels = Enum.GetNames(typeof(Battery_Model_Type));
                foreach (var m in allModels)
                {
                    if (string.Compare(model, m, true) == 0)
                    {
                        isFound = true;
                    }
                }
                if (!isFound)
                {
                    throw new ArgumentException($@"The is no ""{model}""");
                }
            }
            else
            {
                throw new ArgumentException($@"{model} value cant be null or empty");
            }

        }

        internal static void TimeSpan(string timespan)
        {
            try
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
            catch (Exception)
            {

                throw new ArgumentException($@"{timespan} value cant be null or empty");
            }

        }

        // Model of Validation Comparison
    }
}
