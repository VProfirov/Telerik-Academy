using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Resource
{
    using Academy.Models.Contracts;
    using Academy.Models.Resource.Validation;

    class DemoResource:ILectureResouce
    {
        private string _name;

        private string _url;

        public string Name {
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

        public DemoResource(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("    * Resource: ");
            sb.AppendLine($"     - Name: {this.Name}");
            sb.AppendLine($"     - Url: {this.Url}");
            sb.AppendLine("     - Type: Demo");

            return sb.ToString();
        }
    }
}
