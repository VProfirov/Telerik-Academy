using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils.Validation
{
    using System.CodeDom;
    using Academy.Models.Enums;
    using static Academy.Models.Utils.Validation.Abstract.Validator;

    internal static class CurriculumValidator
    {
        public const int CourseNameLengthMin = 3;
        public const int CourseNameLengthMax = 45;
        public const string CourseNameErrorMessage = "The name of the course must be between {0} and {1} symbols!";

        public const string TrackEnumErrorMessage = "The provided track is not valid!";

        public const int LecturesPerWeekMin = 1;
        public const int LecturesPerWeekMax = 7;
        public const string LecturesPerWeekErrorMessage = "The number of lectures per week must be between {0} and {1}!";


        internal static string CoursenameValidation(string coursename)
        {
            StringValidation(coursename, CourseNameLengthMin, CourseNameLengthMax, CourseNameErrorMessage);
            return coursename;
        }

        internal static int LecturesPerWeekValidation(int lecturesPerWeek)
        {
            NumberValidation(lecturesPerWeek, LecturesPerWeekMin, LecturesPerWeekMax, LecturesPerWeekErrorMessage);
            return lecturesPerWeek;
        }

        internal static Track TrackValidation(string track)
        {
            //Generic implementation possible : https://msdn.microsoft.com/en-us/library/dd991317(v=vs.110).aspx
            // if generic => pass it to a CurriculumValidator method
            try
            {
                var validTrack = (Track)Enum.Parse(typeof(Track), track);
                return validTrack;
            }
            catch
            {
                throw new ArgumentException(TrackEnumErrorMessage);
            }
        }
    }
}
