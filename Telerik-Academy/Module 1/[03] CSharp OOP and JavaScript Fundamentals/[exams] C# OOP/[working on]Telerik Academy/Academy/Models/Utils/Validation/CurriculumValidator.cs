using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils.Validation
{
    using System.CodeDom;

    using static Academy.Models.Utils.Validation.Abstract.Validator;
    using Academy.Models.Enums;

    internal static class CurriculumValidator
    {
        public const int CourseNameLength_MIN = 3;
        public const int CourseNameLength_MAX = 45;
        public const string CourseNameErrorMessage = "The name of the course must be between {0} and {1} symbols!";

        public const string TrackEnumErrorMessage = "The provided track is not valid!";

        internal static string CoursenameValidation(string coursename)
        {
            StringValidation(coursename, CourseNameLength_MIN, CourseNameLength_MAX, CourseNameErrorMessage);
            return coursename;
        }

        internal static int LecturesPerWeekValidation(string lecturesPerWeek)
        {
            throw new NotImplementedException();
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
