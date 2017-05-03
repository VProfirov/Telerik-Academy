using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Model_Validator;

namespace Academy.Models.Resource
{
    abstract class AbstractBaseResource:ILectureResouce
    {
        private string name;
        private string url;
        public AbstractBaseResource(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public string Name
        {
            get => this.name;
            set
            {
                Validator.StringValidation(value,Validator.);
                this.name = value;
            }
        }

        public string Url
        {
            get => this.url;
            set
            {
                Validator.StringValidation(value,Validator.);
            }
        }

        public override string ToString()
        {
            return base.ToString();//TODO Output AbstractBaseResource
        }
    }
}
