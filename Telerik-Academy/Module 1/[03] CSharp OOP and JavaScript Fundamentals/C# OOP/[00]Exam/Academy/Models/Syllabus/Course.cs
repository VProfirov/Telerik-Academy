namespace Academy.Models.Syllabus
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using Academy.Models.Contracts;

    internal class Course : ICourse
    {
        private string _name;
        private int _lecturesPerWeek;

        /*
         CreateCourse [moron?=>]<seasonId>[<=?] <name> <lecturesPerWeek> <startingDate> 
         - Creates a new lecture with the given name, lectures per week count and starting date, into the season with that ID.
             */
        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = int.Parse(lecturesPerWeek);
            this.StartingDate = DateTime.Parse(startingDate);
        }

//        public int SeasonID { get; set; }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 45)
                {
                    throw new ArgumentException("The name of the course must be between 3 and 45 symbols!");
                }
                this._name = value;
            }
        }

        public int LecturesPerWeek
        {
            get
            {
                return this._lecturesPerWeek;
            }
            set
            {
                if (value < 1 || value > 7)
                {
                    throw new ArgumentException("The number of lectures per week must be between 1 and 7!");
                }
                this._lecturesPerWeek = value;
            }
        }

        public DateTime StartingDate { get; set; }

        public DateTime EndingDate {
            get
            {
                return this.StartingDate.AddDays(30);
            }
            set
            {
                // what is mean?
                //throw new NotImplementedException();
            }
        }

        public IList<IStudent> OnsiteStudents { get;} = new List<IStudent>();

        public IList<IStudent> OnlineStudents { get;} = new List<IStudent>();

        public IList<ILecture> Lectures { get;} = new List<ILecture>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("* Course");
            sb.AppendLine($" - Name: {this.Name}");
            sb.AppendLine($" - Lectures per week: {this.LecturesPerWeek}");
            sb.AppendLine($" - Starting date: {this.StartingDate}");
            sb.AppendLine($" - Ending date: {this.EndingDate}");
            sb.AppendLine(" - Lectures:");

            if (this.Lectures.Count == 0)
            {
                sb.AppendLine("  * There are no lectures in this course!");
            }
            else
            {
                foreach (var lecture in this.Lectures)
                {
                    sb.AppendLine($"{lecture}");
                }
            }


            return sb.ToString();
        }
    }
}