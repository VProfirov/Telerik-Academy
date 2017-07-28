using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Outputs;
using Academy.Models.Validation;

namespace Academy.Models.Academy_Constructs
{
    class Course:ICourse
    {
        private string _name;
        private int _lecturesPerWeek;
//        private DateTime _endingDate;

        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = int.Parse(lecturesPerWeek);
            this.StartingDate = DateTime.Parse(startingDate);
            this.EndingDate = this.StartingDate.AddDays(30);
        }

        public string Name
        {
            get => this._name;
            set
            {
                Validator.StringValidation(value, Validator.CourseNameMinLength, Validator.CourseNameMaxLength, Validator.CourseNameErrorMessage);
                this._name = value;
            }
        }

        public int LecturesPerWeek
        {
            get => this._lecturesPerWeek;
            set
            {
                Validator.NumberValidation(value, Validator.LecturesPerWeekMin, Validator.LecturesPerWeekMax, Validator.LecturesPerWeekErrorMessage);
                this._lecturesPerWeek = value;
            }
        }

        public DateTime StartingDate { get; set; }

        public DateTime EndingDate { get; set; }

        public IList<IStudent> OnsiteStudents { get; } = new List<IStudent>();

        public IList<IStudent> OnlineStudents { get; } = new List<IStudent>();

        public IList<ILecture> Lectures { get; } = new List<ILecture>();

        public override string ToString()
        {
            return ConstructsOutput.CourseOutput(this);
        }
    }
}
