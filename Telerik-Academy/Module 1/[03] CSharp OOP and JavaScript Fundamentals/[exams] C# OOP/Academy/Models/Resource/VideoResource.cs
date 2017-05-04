using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Outputs;

namespace Academy.Models.Resource
{
    class VideoResource:AbstractLectureResource
    {
        public VideoResource(string name, string url, DateTime uploadedOn) : base(name, url)
        {
            this.UploadedOn = uploadedOn;
        }

        public DateTime UploadedOn { get; }

        public override string ToString()
        {
            return BaseResourceOutput.ResourceOutput(this, this.UploadedOn);
        }
    }
}
