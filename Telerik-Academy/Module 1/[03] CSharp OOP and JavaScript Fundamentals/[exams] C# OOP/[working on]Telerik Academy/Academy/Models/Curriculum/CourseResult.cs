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

    internal class CourseResult : ICourseResult
    {
        public CourseResult(ICourse course, float examPoints, float coursePoints)
        {
            this.Course = course;
            this.ExamPoints = ExamPointsValidation(examPoints);
            this.CoursePoints = CoursePointsValidation(coursePoints);

            if (this.ExamPoints >= 65 || this.CoursePoints >= 75)
            {
                this.Grade = Grade.Excellent;
            }////Todo: examPoints 65 vs 60 ?
            else if ((this.ExamPoints < 65 && this.ExamPoints >= 30) || (this.CoursePoints < 75 && this.CoursePoints >= 45))
            {
                this.Grade = Grade.Passed;
            }
            else
            {
                this.Grade = Grade.Failed;
            }

            // (autoProp VS error: Grade{get=> this._grade}) => this.Grade - field init using auto-gen props
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
