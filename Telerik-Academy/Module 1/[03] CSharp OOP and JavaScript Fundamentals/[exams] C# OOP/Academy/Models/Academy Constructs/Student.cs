using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Utils.Contracts;

namespace Academy.Models.Academy_Constructs
{
    class Student:IStudent
    {
        public Student(string username, string track)
        {
            
        }
        public string Username { get; set; }
        public Track Track { get; set; }
        public IList<ICourseResult> CourseResults { get; set; }

        public override string ToString()
        {
            return base.ToString();//TODO Output
        }
    }
}
