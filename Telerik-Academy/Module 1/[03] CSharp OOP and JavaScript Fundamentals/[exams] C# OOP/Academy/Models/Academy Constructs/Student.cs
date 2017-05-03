using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Model_Validator;
using Academy.Models.Utils.Contracts;

namespace Academy.Models.Academy_Constructs
{
    class Student:IStudent
    {
        private string username;

        public Student(string username, string track)
        {
            this.Username = username;
            this.Track = (Track)Enum.Parse(typeof(Track), track);
        }

        public string Username
        {
            get => this.username;
            set
            {
                Validator.StringValidation(value,Validator.);
                this.username = value
            }
        }
        public Track Track { get; set; }
        public IList<ICourseResult> CourseResults { get; set; } = new List<ICourseResult>();

        public override string ToString()
        {
            return base.ToString();//TODO Output
        }
    }
}
