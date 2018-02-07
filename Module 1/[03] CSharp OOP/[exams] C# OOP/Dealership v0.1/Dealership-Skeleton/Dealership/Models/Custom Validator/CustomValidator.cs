using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dealership.Models.Custom_Validator
{
    public static class CustomValidator
    {
        public static void ValidateStringRange(string value, int minLength, int maxLength, string errorMessage)
        {
            if (value.Length < minLength || value.Length > maxLength)
            {
                throw new ArgumentException(string.Format(errorMessage, minLength, maxLength));
            }
        }

        //Built in Validator Rework =>

        public static void ValidateIntRange(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(string.Format(message,min,max));
            }
        }

        public static void ValidateDecimalRange(decimal value, decimal min, decimal max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(string.Format(message,min,max));
            }
        }

        public static void ValidateNull(object value, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void ValidateSymbols(string value, string pattern, string message)
        {
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);

            if (!regex.IsMatch(value))
            {
                throw new ArgumentException(string.Format(message,value));
            }
        }
    }
}
