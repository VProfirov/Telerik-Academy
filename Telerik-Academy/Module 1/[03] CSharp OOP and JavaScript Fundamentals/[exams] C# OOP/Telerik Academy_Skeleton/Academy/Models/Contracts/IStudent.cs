using Academy.Models.Utils.Contracts;
using System.Collections.Generic;
using Academy.Models.Sections.Section_1.Utils;
namespace Academy.Models.Contracts
{
    public interface IStudent : IUser
    {
        Track Track { get; set; }

        IList<ICourseResult> CourseResults { get; set; }
    }
}
