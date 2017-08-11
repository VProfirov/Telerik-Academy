using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils.Validation
{
    using static Academy.Models.Utils.Validation.Abstract.Validator;

    internal static class ResourcesValidator
    {

        public const string ResourceUrlErrorMessage = "Resource url should be between {0} and {1} symbols long!";
        public const int ResourceUrlMinLength = 5;
        public const int ResourceUrlMaxLength = 150;

        public const string ResourceNameErrorMessage = "Resource name should be between {0} and {1} symbols long!";
        public const int ResourceNameMinLength = 3;
        public const int ResourceNameMaxLength = 15;

        internal static string NameValidation(string name)
        {
            StringValidation(name, ResourceNameMinLength, ResourceNameMaxLength, ResourceNameErrorMessage);
            return name;
        }

        internal static string UrlValidation(string url)
        {
            StringValidation(url, ResourceUrlMinLength, ResourceUrlMaxLength, ResourceUrlErrorMessage);
            return url;
        }
    }
}
