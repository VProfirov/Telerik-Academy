using Academy.Models.Utils.Contracts;
using System.Collections.Generic;

namespace Academy.Models.Contracts
{
    using Academy.Models.Enums;

    public interface IStudent : IUser
    {
        Track Track { get; set; }

        IList<ICourseResult> CourseResults { get; set; }
    }
}
