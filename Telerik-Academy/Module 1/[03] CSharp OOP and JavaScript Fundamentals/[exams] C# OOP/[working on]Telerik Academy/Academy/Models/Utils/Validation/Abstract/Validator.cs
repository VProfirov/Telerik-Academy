namespace Academy.Models.Utils.Validation.Abstract
{
    using System;
    using System.Collections.Generic;

    using Academy.Models.Enums;

    internal static class Validator
    {
        internal static void NumberValidation(int value, int min, int max, string errorMessage)
        {
            if (value < min || value > max)
                throw new ArgumentException(string.Format(errorMessage, min, max));
        }

        internal static void NumberValidation(float value, int min, int max, string errorMessage)
        {
            if (value < min || value > max)
                throw new ArgumentException(string.Format(errorMessage, min, max));
        }

        internal static void StringValidation(string value, int minLength, int maxLength, string errorMessage)
        {
            if (value.Length < minLength || value.Length > maxLength || string.IsNullOrEmpty(value))
                throw new ArgumentException(string.Format(errorMessage, minLength, maxLength));
        }

        internal static void EmptyUserListValidation(IList<IUser> value,string errorMessage)
        {
            if (value.Count == 0)
                throw new ArgumentException(errorMessage);
        }
        
    }
}
