using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Resource.Validation
{
    static class ValidateResource
    {
        public static string Name(string name)
        {
            if (string.IsNullOrEmpty(name) || (name.Length < 3 || name.Length > 15))
            {
                throw new ArgumentException("Resource name should be between 3 and 15 symbols long!");
            }
            return name;
        }

        public static string URI(string uri)
        {
            if (string.IsNullOrEmpty(uri) || (uri.Length < 5 || uri.Length > 150))
            {
                throw new ArgumentException("Resource url should be between 5 and 150 symbols long!");
            }
            return uri;
        }
    }
}
