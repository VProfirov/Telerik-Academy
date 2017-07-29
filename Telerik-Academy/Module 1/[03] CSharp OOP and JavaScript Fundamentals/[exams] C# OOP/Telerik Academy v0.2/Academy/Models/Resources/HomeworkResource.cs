using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Outputs;

namespace Academy.Models.Resources
{
    class HomeworkResource:LectureResource
    {
        public HomeworkResource(string name, string url, DateTime currentDate) : base(name, url)
        {
            this.DueDate = currentDate.AddDays(7);
        }

        private DateTime DueDate { get; set; }

        public override string ToString()
        {
            return LectureResourceOutput.ResourceOutput(this, this.DueDate);
        }
    }
}
