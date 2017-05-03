using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Model_Validator;

namespace Academy.Models.Academy_Constructs
{
    class Trainer:ITrainer
    {
        private string username;
        private IList<string> technologies;

        public Trainer(string username, string technologies)
        {
            this.Username = username;
            this.Technologies = technologies.Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries);
        }

        public string Username
        {
            get => this.username;
            set
            {
                Validator.StringValidation(value,Validator.);
                this.username = value;
            }
        }

        public IList<string> Technologies
        {
            get => this.technologies;
            set
            {
                foreach (var tech in this.technologies)
                {
                    Validator.StringValidation(tech);
                }
                this.technologies = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();//TODO Output
        }
    }
}
