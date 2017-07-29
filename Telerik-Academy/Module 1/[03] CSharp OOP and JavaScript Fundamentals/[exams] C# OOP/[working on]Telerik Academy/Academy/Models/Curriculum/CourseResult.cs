using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Curriculum
{
    using Academy.Models.Contracts;
    using Academy.Models.Enums;
    using Academy.Models.Utils.Contracts;
    using Academy.Models.Utils.Output;

    using static Utils.Validation.CurriculumValidator;

    internal class CourseResult: ICourseResult
    {
        private ICourse course;
        private float examPoints;
        private float coursePoints;

        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            this.course = course;
            this.examPoints = CoursePointsValidation(coursePoints);
            this.coursePoints = ExamPointsValidation(examPoints);
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
            return StringFormatOutput.CourseResultOutput(this);
        }
    }
}
