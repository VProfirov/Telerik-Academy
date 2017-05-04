using System;
using System.Collections.Generic;

namespace Academy.Models.Models_Validator
{
    internal class Validator
    {
        public const string CommandsListUsersErrorMessage = "There are no registered users!";

        public const string TrackEnumErrorMessage = "The provided track is not valid!";

        public const string ResourceUrlErrorMessage = "Resource url should be between {0} and {1} symbols long!";
        public const int ResourceUrlMinLength = 5;
        public const int ResourceUrlMaxLength = 150;

        public const string ResourceNameErrorMessage = "Resource name should be between {0} and {1} symbols long!";
        public const int ResourceNameMinLength = 3;
        public const int ResourceNameMaxLength = 15;

        public const string LectureNameErrorMessage = "Lecture's name should be between {0} and {1} symbols long!";
        public const int LectureNameMinLength = 5;
        public const int LectureNameMaxLength = 30;

        public const string ExamPointsErrorMessage = "Course result's exam points should be between {0} and {1}!";
        public const int ExamPointsMin = 0;
        public const int ExamPointsMax = 1000;

        public const string CoursePointsErrorMessage = "Course result's course points should be between {0} and {1}!";
        public const int CoursePointsMin = 0;
        public const int CoursePointsMax = 125;

        public const string UsernameErrorMessage = "User's username should be between {0} and {1} symbols long!";
        public const int UsernameMinLength = 3;
        public const int UsernameMaxLength = 16;

        public const string LecturesPerWeekErrorMessage = "The number of lectures per week must be between {0} and {1}!" ;
        public const int LecturesPerWeekMin = 1;
        public const int LecturesPerWeekMax = 7;

        public const string CourseNameErrorMessage = "The name of the course must be between {0} and {1} symbols!";
        public const int CourseNameMinLength = 3;
        public const int CourseNameMaxLength = 45;

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
        
        public static void EmptyUserListValidation(IList<IUser> value)
        {
            if (value.Count == 0)
            throw new ArgumentException(CommandsListUsersErrorMessage);
        }
    }
}