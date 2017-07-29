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
            this.examPoints = ExamPointsValidation(coursePoints);
            this.coursePoints = CoursePointsValidation(examPoints);

            if (this.ExamPoints >= 65 || this.CoursePoints >= 75)
            {
                this.Grade = Grade.Excellent;
            }
            else if ((this.ExamPoints < 65 && this.ExamPoints >= 30) || (this.CoursePoints < 75 && this.CoursePoints >= 45))
            {
                this.Grade = Grade.Passed;
            }
            else
            {
                this.Grade = Grade.Failed;
            }

            // this.Grade (enum prop) VS this._grade (enum field)
        }

        public ICourse Course { get; }

        public float ExamPoints { get; }

        public float CoursePoints { get; }

        public Grade Grade { get; }

        public override string ToString()
        {
            return StringFormatOutput.CourseResultOutput(this);
        }
    }
}
