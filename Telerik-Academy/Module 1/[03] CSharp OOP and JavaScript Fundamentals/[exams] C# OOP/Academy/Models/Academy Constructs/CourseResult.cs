using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;

namespace Academy.Models.Academy_Constructs
{
    class CourseResult:ICourseResult
    {
        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            
        }
        public ICourse Course { get; }
        public float ExamPoints { get; }
        public float CoursePoints { get; }
        public Grade Grade { get; }

        public override string ToString()
        {
            return base.ToString();//TODO Output
        }
    }
}
