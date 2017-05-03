using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;

namespace Academy.Models.Academy_Constructs
{
    class CourseResult:ICourseResult
    {
        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            this.Course = course;
            this.ExamPoints = float.Parse(examPoints);
            this.CoursePoints = float.Parse(coursePoints);
        }
        public ICourse Course { get; }
        public float ExamPoints { get; }
        public float CoursePoints { get; }
        public Grade Grade { get; } //TODO: Implement grading GET

        public override string ToString()
        {
            return base.ToString();//TODO Output
        }
    }
}
