using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Resources
{
    using Academy.Models.Resources.Abstract;
    using Academy.Models.Utils.Output;

    internal class HomeworkResource : LectureResource
    {
        public HomeworkResource(string name, string url, DateTime currentDate)
            : base(name, url)
        {
            this.DueDate = currentDate.AddDays(7);
        }

        private DateTime DueDate { get; set; }

        public override string ToString()
        {
            return StringFormatOutput.ResourceOutput(this, this.DueDate);
        }
    }
}
