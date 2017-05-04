using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Outputs;

namespace Academy.Models.Resource
{
    class HomeworkResource:AbstractLectureResource
    {
        private DateTime _dueDate;

        public HomeworkResource(string name, string url, DateTime dueDate) : base(name, url)
        {
            this.DueDate = dueDate;
        }

        public DateTime DueDate
        {
            get => this._dueDate;
            set { this._dueDate = value.AddDays(7); }

        }

        public override string ToString()
        {
            return BaseResourceOutput.ResourceOutput(this,this.DueDate);
        }
    }
}
