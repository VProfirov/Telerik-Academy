using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils.Validation
{
    internal static class CommandsValidation
    {
        internal static class ListUsersCommandValidation
        {
            public const string CommandsListUsersErrorMessage = "There are no registered users!";

            internal static void EmptyUserListValidation(IList<IUser> value)
            {
                if (value.Count == 0)
                    throw new ArgumentException(CommandsListUsersErrorMessage);
            }
        }
    }
}
