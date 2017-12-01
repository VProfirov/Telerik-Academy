using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Resource
{
    using Academy.Models.Contracts;
    using Academy.Models.Resource.Validation;

    class HomeworkResource: ILectureResouce
    {

        private string _name;

        private string _url;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = ValidateResource.Name(value);
            }
        }

        public string Url
        {
            get
            {
                return this._url;
            }
            set
            {
                this._url = ValidateResource.URI(value);
            }
        }

        public DateTime DueDate { get; set; } 


        public HomeworkResource(string name, string url, DateTime curreDateTime)
        {
            this.Name = name;
            this.Url = url;
            this.DueDate = curreDateTime.AddDays(7);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("    * Resource: ");
            sb.AppendLine($"     - Name: {this.Name}");
            sb.AppendLine($"     - Url: {this.Url}");
            sb.AppendLine("     - Type: Homework");
            sb.AppendLine($"     - Due date: {this.DueDate}");

            return sb.ToString();
        }
    }

}
