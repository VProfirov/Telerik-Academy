using System;

namespace Enumeraition_Use
{
    class Program
    {
        enum Grade
        {
            Failed,
            Passed,
            Excellent
        }
        static void Main(string[] args)
        {
            var cr = new CourseResult("C#", "60", "50");
            Console.WriteLine(cr.Grade);
            Console.WriteLine(cr.ExamPoints);
        }

        class CourseResult
        {
            private string course;
            private readonly float examPoints;
            private float coursePoints;

            public Grade grade;

            public  int accessCode;

//            public readonly int accessCode;

            public CourseResult(string course, string examPoints, string coursePoints)
            {
                this.course = course;
                this.ExamPoints = float.Parse(examPoints);
                this.coursePoints = float.Parse(coursePoints);
//                this.Grade = Grade.Excellent; 
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

                // this.Grade (enum prop) VS this._grade (enum field)

                //// NB! init order - defaulting field val-s after ctor use
                //line : 65//this.AccessCode = int.Parse("10"); //// use of auto-props is redundant, so the proper error accurse 
                this.AccessCode = 10; //public  int accessCode; ==> is never used
            }

            public string Course { get; }

            public float ExamPoints { get; }

            public float CoursePoints { get; }

            public Grade Grade { get; }

//            public int AccessCode { get => this.accessCode; }
            public int AccessCode { get; }
        }
    }
}