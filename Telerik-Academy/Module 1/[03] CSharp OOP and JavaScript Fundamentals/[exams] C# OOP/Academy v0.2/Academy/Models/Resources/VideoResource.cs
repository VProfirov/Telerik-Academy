using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Outputs;

namespace Academy.Models.Resources
{
    class VideoResource:LectureResource
    {
        public VideoResource(string name, string url,DateTime currentDate) : base(name, url)
        {
            this.UploadedOn = currentDate;
        }

        private DateTime UploadedOn { get; set; }

        public override string ToString()
        {
            return LectureResourceOutput.ResourceOutput(this, this.UploadedOn);
        }
    }
}
