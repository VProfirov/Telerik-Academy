using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Academy.Models.Contracts;
using Academy.Core.Providers;
namespace Academy.Models.Sections.Section_1
{
    public class Course : ICourse
    {
        //Fields Seciton
        // use of readonly requires property external(constructor) validation
        private string _name;
        private int _lecturesPerWeek;

        //TODO: VP: AcademyFactory to Implement ctor
        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = int.Parse(lecturesPerWeek);//tryParse if validation needed
            // at this point intelisence stoped working ....
            //this.StartingDate = DateTime.Parse(startingDate, DateTimeProvider.Now);
            //this.StartingDate = DateTime.ParseExact(startingDate, DateTimeProvider.Now);  
            this.StartingDate = DateTime.Parse(startingDate);
        }

        //Properties Section
        public DateTime EndingDate { get; set; }

        public IList<ILecture> Lectures { get; }

        public int LecturesPerWeek
        {
            get
            {
                return _lecturesPerWeek;
            }

            set
            {
                if (value <1 || value>7)
                {
                    throw new ArgumentException("The name of the course must be between 3 and 45 symbols!");
                }
                this._lecturesPerWeek = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || (value.Length<3 || value.Length>45))
                {
                    throw new ArgumentException("The name of the course must be between 3 and 45 symbols!");
                }
                this._name = value;
            }
        }

        public IList<IStudent> OnlineStudents { get; }

        public IList<IStudent> OnsiteStudents { get; }

        public DateTime StartingDate { get; set; }

        //Methods Section
        public override string ToString()
        {
            StringBuilder printBuilder = new StringBuilder();
            printBuilder.AppendLine("* Course");
            printBuilder.AppendLine($" - Name: {this.Name}");
            printBuilder.AppendLine($" - Lectures per week: <{this.LecturesPerWeek}>");
            printBuilder.AppendLine($" - Starting date: startingDate"); // to implement course <startingDate>
            printBuilder.AppendLine($" - Ending date: endingDate"); // to implement course <endingDate>
            printBuilder.AppendLine(" - Lectures:");
            printBuilder.AppendLine("  * There are no lectures in this course!");

            string message = printBuilder.ToString();
            return message;
        }
    }
}
