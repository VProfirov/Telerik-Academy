using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;
using Academy.Models.Validation;
using Academy.Models.Outputs;
namespace Academy.Models.Academy_Constructs
{
    class Student:IStudent
    {
        private string _username;

        public Student(string username, string track)
        {
            this.Username = username;

            try
            {
                this.Track = (Track)Enum.Parse(typeof(Track), track);
            }
            catch
            {
                throw new ArgumentException(Validator.TrackEnumErrorMessage);
            }
        }

        public string Username
        {
            get => this._username;
            set
            {
                Validator.StringValidation(value, Validator.UsernameMinLength, Validator.UsernameMaxLength, Validator.UsernameErrorMessage);
                this._username = value;
            }
        }
        public Track Track { get; set; }
        public IList<ICourseResult> CourseResults { get; set; } = new List<ICourseResult>();

        public override string ToString()
        {
            return ConstructsOutput.StudentOutput(this);
        }
    }
}
