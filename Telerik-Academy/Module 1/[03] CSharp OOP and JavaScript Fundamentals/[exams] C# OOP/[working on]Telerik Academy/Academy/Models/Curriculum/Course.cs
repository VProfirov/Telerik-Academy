using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Curriculum
{
    using Academy.Models.Contracts;
    class Course:ICourse
    {
        private string lecturesPerWeek;
        private string startingDate;

        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            Name = name;
            this.lecturesPerWeek = lecturesPerWeek;
            this.startingDate = startingDate;
        }

        public string Name { get; set; }

        public int LecturesPerWeek { get; set; }

        public DateTime StartingDate { get; set; }

        public DateTime EndingDate { get; set; }

        public IList<IStudent> OnsiteStudents { get; }

        public IList<IStudent> OnlineStudents { get; }

        public IList<ILecture> Lectures { get; }

        public override string ToString()
        {
            //TODO: impl - output class
            throw new NotImplementedException("Create an Output Class");
        }
    }
}
