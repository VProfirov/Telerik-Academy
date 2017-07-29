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

        public const int CoursePointsMin = 0;
        public const int CoursePointsMax = 125;
        public const string CoursePointsErrorMessage = "Course result's course points should be between {0} and {1}!";

        public const int ExamPointsMin = 0;
        public const int ExamPointsMax = 1000;
        public const string ExamPointsErrorMessage = "Course result's exam points should be between {0} and {1}!";
        
        public const string TrackEnumErrorMessage = "The provided track is not valid!";

        public const int LectureNameMinLength = 5;
        public const int LectureNameMaxLength = 30;
        public const string LectureNameErrorMessage = "Lecture's name should be between {0} and {1} symbols long!";

        public const int LecturesPerWeekMin = 1;
        public const int LecturesPerWeekMax = 7;
        public const string LecturesPerWeekErrorMessage = "The number of lectures per week must be between {0} and {1}!";


        internal static string CoursenameValidation(string coursename)
        {
            StringValidation(coursename, CourseNameLengthMin, CourseNameLengthMax, CourseNameErrorMessage);
            return coursename;
        }
        

        internal static float CoursePointsValidation(string coursePoints)
        {
            var cP = float.Parse(coursePoints);
            NumberValidation(cP, ExamPointsMin, ExamPointsMax, ExamPointsErrorMessage);
            return cP;
        }

        internal static float ExamPointsValidation(string examPoints)
        {
            var exP = float.Parse(examPoints);
            NumberValidation(exP, CoursePointsMin, CoursePointsMax,CoursePointsErrorMessage);
            return exP;
        }

        internal static string LectureNameValidation(string lectureName)
        {
            StringValidation(lectureName, LectureNameMinLength, LectureNameMaxLength, LectureNameErrorMessage);
            return lectureName;
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
