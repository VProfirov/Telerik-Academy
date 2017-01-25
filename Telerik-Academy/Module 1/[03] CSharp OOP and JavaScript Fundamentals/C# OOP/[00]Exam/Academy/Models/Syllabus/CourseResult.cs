namespace Academy.Models.Syllabus
{
    using System;
    using System.Text;

    using Academy.Models.Contracts;
    using Academy.Models.Enums;
    using Academy.Models.Utils.Contracts;

    internal class CourseResult : ICourseResult
    {
        private Grade _grade;

        private float _examPoints;

        private float _coursePoints;

        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            this.Course = course;
            this.ExamPoints = float.Parse(examPoints);
            this.CoursePoints = float.Parse(coursePoints);
            this.CalculateGrade();
        }

        public ICourse Course { get; set; }

        public float ExamPoints {
            get
            {
                return this._examPoints;
            }
            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentException("Course result's exam points should be between 0 and 1000!");
                }
                this._examPoints = value;
            }
        }

        public float CoursePoints {
            get
            {
                return _coursePoints;
            }
            set
            {
                if (value < 0 || value>125)
                {
                    throw new ArgumentException("Course result's course points should be between 0 and 125!");
                }
                this._coursePoints = value;

            }
        }

        public Grade Grade { get; }

        public void CalculateGrade()
        {
            if ( this.ExamPoints >= 65 || this.CoursePoints >= 75)
            {
                this._grade = Grade.Excelent;
            }
            else if ((this.ExamPoints < 60 && this.ExamPoints >= 30) || (this.CoursePoints < 75 && this.CoursePoints >= 45))
            {
                this._grade = Grade.Passed;
            }
            else
            {
                this._grade = Grade.Failed;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  * {this.Course.Name}: Points - {this.CoursePoints}, Grade - {this.Grade}");
            return sb.ToString();
        }
    }
}