using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Validation;
using Academy.Models.Outputs;
namespace Academy.Models.Academy_Constructs
{
    class Trainer:ITrainer
    {
        private string _username;
        public Trainer(string username, string technologies)
        {
            this.Username = username;
            this.Technologies = technologies.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();////missing .ToList will couse Exception when/if the Property is tried to be accessed as List (which in this context it should use List)
        }

        public string Username
        {
            get => this._username;
            set
            {
                Validator.StringValidation(value, Validator.UsernameMinLength, Validator.UsernameMaxLength, Validator.UsernameErrorMessage);
                this._username = value;
            }
        }

        public IList<string> Technologies { get; set; } = new List<string>();

        public override string ToString()
        {
            return ConstructsOutput.TrainerOutput(this);
        }
    }
}
