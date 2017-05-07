namespace Academy.Models.Resource
{
    using System.Text;

    using Academy.Models.Contracts;
    using Academy.Models.Resource.Validation;

    class PresentationResource: ILectureResouce
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

        public PresentationResource(string name, string url)
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
            sb.AppendLine("     - Type: Presentation");

            return sb.ToString();
        }
    }
}
