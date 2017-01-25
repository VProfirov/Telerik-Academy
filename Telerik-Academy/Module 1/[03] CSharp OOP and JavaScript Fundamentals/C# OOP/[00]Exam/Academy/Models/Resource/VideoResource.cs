namespace Academy.Models.Resource
{
    using System;
    using System.Text;

    using Academy.Models.Contracts;
    using Academy.Models.Resource.Validation;

    class VideoResource: ILectureResouce
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

        public DateTime UploadedOn { get; set; }

        public VideoResource(string name, string url, DateTime currDateTime)
        {
            this.Name = name;
            this.Url = url;
            this.UploadedOn = currDateTime;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("    * Resource: ");
            sb.AppendLine($"     - Name: {this.Name}");
            sb.AppendLine($"     - Url: {this.Url}");
            sb.AppendLine("     - Type: Video");
            sb.AppendLine($"     - Uploaded on: {this.UploadedOn}");
            return sb.ToString();
        }
    }
}
