using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Models_Validator;
using Academy.Models.Outputs;

namespace Academy.Models.Academy_Constructs
{
    class Course : ICourse
    {
        private string _name;
        private int _lecturesPerWeek;
        private DateTime _endingDate;
        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = int.Parse(lecturesPerWeek);
            this.StartingDate = DateTime.Parse(startingDate);
        }

        public string Name
        {
            get => this._name;
            set
            {
                Validator.StringValidation(value,Validator.CourseNameMinLength,Validator.CourseNameMaxLength,Validator.CourseNameErrorMessage);
                this._name = value;
            }
        }

        public int LecturesPerWeek
        {
            get => this._lecturesPerWeek;
            set
            {
                Validator.NumberValidation(value,Validator.LecturesPerWeekMin,Validator.LecturesPerWeekMax,Validator.LecturesPerWeekErrorMessage);
                this._lecturesPerWeek = value;
            }
        }
        public DateTime StartingDate { get; set; }

        public DateTime EndingDate
        {
            get => this._endingDate;
            set
            {
                if ( this._endingDate == default(DateTime))
                {
                    this._endingDate = this.StartingDate.AddDays(30);
                }
                this._endingDate = value;
            }
        }

        public IList<IStudent> OnsiteStudents => new List<IStudent>();

        public IList<IStudent> OnlineStudents => new List<IStudent>();

        public IList<ILecture> Lectures => new List<ILecture>();

        public override string ToString()
        {
            return ConstructsOuput.CourseOutput(this);
        }
    }
}
