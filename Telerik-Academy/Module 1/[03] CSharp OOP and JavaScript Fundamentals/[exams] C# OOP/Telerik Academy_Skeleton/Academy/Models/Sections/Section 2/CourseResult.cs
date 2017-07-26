using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;

namespace Academy.Models.Sections.Section_2
{
    public class CourseResult : ICourseResult
    {
        //TODO: VP: Implement - use section 2-3
        public ICourse Course
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float CoursePoints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float ExamPoints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Grade Grade
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
