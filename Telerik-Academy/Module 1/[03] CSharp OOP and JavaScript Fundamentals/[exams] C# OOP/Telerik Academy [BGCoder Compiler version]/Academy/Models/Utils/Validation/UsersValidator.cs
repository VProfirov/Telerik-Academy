using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils.Validation
{
    using static Academy.Models.Utils.Validation.Abstract.Validator;
    internal static class UsersValidator
    {
        private const int UsernameLength_MIN = 3;
        private const int UsernameLength_MAX = 16;
        private const string UsernameErrorMessage = "User's username should be between {0} and {1} symbols long!";

        internal static string UsernameValidation(string username)
        {
            StringValidation(username, UsernameLength_MIN, UsernameLength_MAX, UsernameErrorMessage);
            return username;
        }
    }
}
