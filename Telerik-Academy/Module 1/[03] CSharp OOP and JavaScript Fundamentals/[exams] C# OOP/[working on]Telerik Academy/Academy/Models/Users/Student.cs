using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Users
{
    using Academy.Models.Contracts;
    using Academy.Models.Enums;
    using Academy.Models.Utils.Contracts;
    using static Utils.Validation.UsersValidator;
    using static Utils.Validation.CurriculumValidator;

    internal class Student : IStudent
    {
        private string username;

        public Student(string username, string track)
        {
            this.Username = username;
            this.Track = TrackValidation(track);
        }

        public string Username
        {
            get => this.username;
            set => this.username = UsernameValidation(value);
        }

        public Track Track { get; set; }

        public IList<ICourseResult> CourseResults { get; set; } = new List<ICourseResult>();

        public override string ToString()
        {
            //TODO: impl - output class
            throw new NotImplementedException("Create an Output Class");
        }
    }
}
