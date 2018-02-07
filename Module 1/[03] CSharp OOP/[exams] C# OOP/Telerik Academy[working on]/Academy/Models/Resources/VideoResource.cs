using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Resources
{
    using Academy.Models.Resources.Abstract;
    using Academy.Models.Utils.Output;

    internal class VideoResource: LectureResource
    {
        public VideoResource(string name, string url, DateTime currentDate)
            : base(name, url)
        {
            this.UploadedOn = currentDate;
        }
        
        private DateTime UploadedOn { get; }

        public override string ToString()
        {
            return StringFormatOutput.ResourceOutput(this, this.UploadedOn);
        }
    }
}
