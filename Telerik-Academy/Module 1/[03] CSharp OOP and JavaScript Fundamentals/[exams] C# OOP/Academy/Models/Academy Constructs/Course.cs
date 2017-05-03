using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Model_Validator;
namespace Academy.Models.Academy_Constructs
{
    class Course : ICourse
    {
        private string name;
        private int lecturesPerWeek;
        private DateTime endingDate;
        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            this.Name = name;

            int lw;
            if (int.TryParse(lecturesPerWeek,out lw))
            {
                this.LecturesPerWeek = lw;
            }

            DateTime sd;
            if (DateTime.TryParse(startingDate,out sd))
            {
                this.StartingDate = sd;
            }
        }

        public string Name
        {
            get => this.name;
            set
            {
                Validator.StringValidation(value,Validator.CourseName_MinLength,Validator.CourseName_MaxLength,Validator.CourseName_ErrorMessage);
                this.name = value;
            }
        }

        public int LecturesPerWeek
        {
            get => this.lecturesPerWeek;
            set
            {
                Validator.NumberValidation(value,Validator.LecturesPerWeek_Min,Validator.LecturesPerWeek_Max,Validator.LecturesPerWeek_ErrorMessage);
                this.lecturesPerWeek = value;
            }
        }
        public DateTime StartingDate { get; set; }

        public DateTime EndingDate
        {
            get => this.endingDate;
            set
            {
                if ( this.endingDate == default(DateTime))
                {
                    this.endingDate = this.StartingDate.AddDays(30);
                }
                this.endingDate = value;
            }
        }

        public IList<IStudent> OnsiteStudents => new List<IStudent>();

        public IList<IStudent> OnlineStudents => new List<IStudent>();

        public IList<ILecture> Lectures => new List<ILecture>();

        public override string ToString()
        {
            return base.ToString();//TODO Output
        }
    }
}
