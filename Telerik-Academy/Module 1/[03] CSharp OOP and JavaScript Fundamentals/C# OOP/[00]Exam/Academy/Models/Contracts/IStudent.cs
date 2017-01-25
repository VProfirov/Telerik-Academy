using Academy.Models.Utils.Contracts;
using System.Collections.Generic;
using Academy.Models.Syllabus;
//[the moron WIN !] not type Track type but string

namespace Academy.Models.Contracts
{
    public interface IStudent : IUser
    {
        Track Track { get; set; }

        IList<ICourseResult> CourseResults { get; set; }
    }
}
