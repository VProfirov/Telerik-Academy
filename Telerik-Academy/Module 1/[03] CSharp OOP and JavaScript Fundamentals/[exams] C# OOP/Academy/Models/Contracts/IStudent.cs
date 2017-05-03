using Academy.Models.Utils.Contracts;
using System.Collections.Generic;

namespace Academy.Models.Contracts
{
    public enum Track
    {
        None = 0,
        Frontend = 1,
        Dev = 2
    }
    public interface IStudent : IUser
    {
        Track Track { get; set; }

        IList<ICourseResult> CourseResults { get; set; }
    }
}
