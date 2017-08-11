using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Resources.Abstract
{
    using Academy.Models.Contracts;
    using Academy.Models.Utils.Output;
    using static Utils.Validation.ResourcesValidator;
    abstract class LectureResource :ILectureResource
    {
        private string name;
        private string url;

        protected LectureResource(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public string Name
        {
            get => this.name;
            set => this.name = NameValidation(value);
        }

        public string Url
        {
            get => this.url;
            set => this.url = UrlValidation(value);
        }

        public override string ToString()
        {
            return StringFormatOutput.ResourceOutput(this);
        }
    }
}
