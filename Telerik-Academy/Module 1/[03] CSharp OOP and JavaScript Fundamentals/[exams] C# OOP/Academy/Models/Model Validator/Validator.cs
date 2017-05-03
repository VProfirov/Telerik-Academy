using System;

namespace Academy.Models.Model_Validator
{
    internal class Validator
    {
        public const string LecturesPerWeek_ErrorMessage = "";
        public const int LecturesPerWeek_Min = 0;
        public const int LecturesPerWeek_Max = 0;

        public const string CourseName_ErrorMessage = "";
        public const int CourseName_MaxLength = 0;
        public const int CourseName_MinLength = 0;

        public static void NumberValidation(int value, int min, int max, string errorMessage)
        {
            if (value < min || value > max)
                throw new ArgumentException(string.Format(errorMessage, min, max));
        }

        public static void NumberValidation(float value, int min, int max, string errorMessage)
        {
            if (value < min || value > max)
                throw new ArgumentException(string.Format(errorMessage, min, max));
        }

        public static void StringValidation(string value, int minLength, int maxLength, string errorMessage)
        {
            if (value.Length < minLength || value.Length > maxLength || string.IsNullOrEmpty(value))
                throw new ArgumentException(string.Format(errorMessage, minLength, maxLength));
        }
    }
}