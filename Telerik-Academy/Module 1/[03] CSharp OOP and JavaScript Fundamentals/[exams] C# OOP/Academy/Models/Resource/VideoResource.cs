using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Resource
{
    class VideoResource:AbstractBaseResource
    {
        public VideoResource(string name, string url) : base(name, url)
        {
        }
    }
}
