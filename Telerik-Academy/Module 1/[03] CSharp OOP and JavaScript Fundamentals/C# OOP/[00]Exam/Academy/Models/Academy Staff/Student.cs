namespace Academy.Models.Academy_Staff
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using Academy.Models.Contracts;
    using Academy.Models.Syllabus;
    using Academy.Models.Utils.Contracts;
    using Academy.Models.Syllabus.Util.Enums;
    internal class Student : IStudent
    {

        private string _username;

        public Student(string username, string track)
        {
            this.Username = username;
            this.Track = (Track)Enum.Parse(typeof(Track),track);
        }

        public IList<ICourseResult> CourseResults { get; set; } = new List<ICourseResult>();

        public Track Track { get; set; }

        public string Username
        {
            get
            {
                return this._username;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
                }
                this._username = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("* Student:");
            sb.AppendLine($" - Username: {this.Username}");
            sb.AppendLine($" - Track: {this.Track}");
            sb.AppendLine($"- Course results:");
            if (this.CourseResults.Count == 0) 
            {
                throw new ArgumentException("  * User has no course results!");
            }
            else
            {
                foreach (var courseResult in this.CourseResults)
                {
                    sb.AppendLine($"{courseResult}");
                }
            }
            return base.ToString();
        }
    }
}