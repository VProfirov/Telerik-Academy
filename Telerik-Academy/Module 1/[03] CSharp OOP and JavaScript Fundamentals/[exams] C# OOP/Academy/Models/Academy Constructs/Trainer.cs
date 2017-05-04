using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Models_Validator;
using Academy.Models.Outputs;

namespace Academy.Models.Academy_Constructs
{
    class Trainer:ITrainer
    {
        private string _username;
        public Trainer(string username, string technologies)
        {
            this.Username = username;
            this.Technologies = technologies.Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries);
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

        public IList<string> Technologies { get; set; }

        public override string ToString()
        {
            return ConstructsOuput.TrainerOutput(this);
        }
    }
}
