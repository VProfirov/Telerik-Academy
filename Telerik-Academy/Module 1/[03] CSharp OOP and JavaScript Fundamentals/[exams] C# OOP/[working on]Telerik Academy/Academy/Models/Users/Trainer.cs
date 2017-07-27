using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Users
{
    using Academy.Models.Contracts;
    using static Utils.Validation.UsersValidator;

    class Trainer:ITrainer
    {
        private string username;

        public Trainer(string username, string technologies)
        {
            Username = username;
            Technologies = technologies.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries); 
        }

        public string Username
        {
            get => this.username;
            set => this.username = UsernameValidation(value);
        }

        public IList<string> Technologies { get; set; } = new List<string>();

        public override string ToString()
        {
            //TODO: impl - output class
            throw new NotImplementedException("Create an Output Class");
        }
    }
}
