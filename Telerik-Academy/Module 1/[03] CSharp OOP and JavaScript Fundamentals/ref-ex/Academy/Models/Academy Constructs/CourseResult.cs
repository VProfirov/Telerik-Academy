using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Validation;
using Academy.Models.Outputs;
using Academy.Models.Utils.Contracts;

namespace Academy.Models.Academy_Constructs
{
    class CourseResult : ICourseResult
    {
        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            this.Course = course;

            var ep = float.Parse(examPoints);
            Validator.NumberValidation(ep, Validator.ExamPointsMin, Validator.ExamPointsMax, Validator.ExamPointsErrorMessage);
            this.ExamPoints = ep;

            var cp = float.Parse(coursePoints);
            Validator.NumberValidation(cp, Validator.CoursePointsMin, Validator.CoursePointsMax, Validator.CoursePointsErrorMessage);
            this.CoursePoints = cp;
        }
        public ICourse Course { get; }
        public float ExamPoints { get; }
        public float CoursePoints { get; }
        public Grade Grade
        {
            get
            {
                if (this.ExamPoints >= 65 || this.CoursePoints >= 75)
                {
                    return Grade.Excellent;
                }
                else if ((this.ExamPoints < 65 && this.ExamPoints >= 30) || (this.CoursePoints < 75 && this.CoursePoints >= 45))
                {
                    return Grade.Passed;
                }
                else
                {
                    return Grade.Failed;
                }
            }
        }

        public override string ToString()
        {
            return ConstructsOutput.CourseResultOutput(this);
        }
    }
}
