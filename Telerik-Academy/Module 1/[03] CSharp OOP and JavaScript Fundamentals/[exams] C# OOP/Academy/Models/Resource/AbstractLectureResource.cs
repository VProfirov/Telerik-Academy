using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Outputs;
using Academy.Models.Validation;

namespace Academy.Models.Resource
{
    abstract class AbstractLectureResource:ILectureResouce
    {
        private string _name;
        private string _url;

        protected AbstractLectureResource(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public string Name
        {
            get => this._name;
            set
            {
                Validator.StringValidation(value,Validator.ResourceNameMinLength,Validator.ResourceNameMaxLength,Validator.ResourceNameErrorMessage);
                this._name = value;
            }
        }

        public string Url
        {
            get => this._url;
            set
            {
                Validator.StringValidation(value, Validator.ResourceUrlMinLength, Validator.ResourceUrlMaxLength,
                    Validator.ResourceUrlErrorMessage);
                this._url = value;
            }
        }

        public override string ToString()
        {
            return BaseResourceOutput.ResourceOutput(this);

            //TODO implement date insertion => abstract VS local
        }
    }
}
