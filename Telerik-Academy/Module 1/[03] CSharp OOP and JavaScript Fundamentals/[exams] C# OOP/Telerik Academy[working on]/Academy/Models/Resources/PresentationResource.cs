using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Resources
{
    using Academy.Models.Curriculum;
    using Academy.Models.Resources.Abstract;

    internal class PresentationResource : LectureResource
    {
        public PresentationResource(string name, string url)
            : base(name, url)
        {
        }
    }
}
