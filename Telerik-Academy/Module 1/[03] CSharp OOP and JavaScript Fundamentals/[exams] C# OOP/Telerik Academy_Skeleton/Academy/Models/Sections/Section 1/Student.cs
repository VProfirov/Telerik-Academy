using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Academy.Models.Contracts;
using Academy.Models.Utils.Contracts;
using Academy.Models.Sections.Section_1.Utils;

namespace Academy.Models.Sections.Section_1
{
    public class Student : IStudent
    {
        private string _userName;

        //TODO: VP: AcademyFactory to Implement ctor
        public Student(string username, string track)
        {
            this.Username = username;
            this.Track.Name = track;
            // Track - reimplementation to be complete (more? then this.Name)
            // Track complete 
        }

        public string Username
        {
            get
            {
                return _userName;
            }

            set
            {
                if (string.IsNullOrEmpty(value)
                   || (value.Length < 3
                   || value.Length > 16))
                {
                    throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
                }
                this._userName = value;
            }
        }

        public IList<ICourseResult> CourseResults { get; set; } // TODO: VP: Recheck for the implementation in Section 2
        public Track Track { get; set; }

        public override string ToString()
        {
            StringBuilder printBuilder = new StringBuilder();

            printBuilder.AppendLine("* Student:");
            printBuilder.AppendLine($" - Username: {this.Username}");
            printBuilder.AppendLine($" - Track: {this.Track}");
                        
            // course results existance condition
            printBuilder.Append(" - Course results:");
            if (CourseResults.Count>0)
            {
                var count = this.CourseResults.Count();
                foreach (var result in this.CourseResults)
                {
                    printBuilder.Append($" {result}");
                    if (--count > 0)
                    {
                        printBuilder.Append(";");
                    }
                }
                printBuilder.AppendLine();
            }
            else
            {
                printBuilder.AppendLine("  * User has no course results!");
            }            

            string message = printBuilder.ToString();
            return message;
        }
    }
    
}
