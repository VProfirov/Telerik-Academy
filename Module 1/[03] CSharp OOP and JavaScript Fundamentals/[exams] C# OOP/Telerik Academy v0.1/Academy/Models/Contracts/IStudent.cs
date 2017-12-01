using Academy.Models.Utils.Contracts;
using System.Collections.Generic;
using Academy.Models.Syllabus;
using Academy.Models.Syllabus.Util.Enums;

namespace Academy.Models.Contracts
{
    public interface IStudent : IUser
    {
        Track Track { get; set; }

        IList<ICourseResult> CourseResults { get; set; }
    }
}
