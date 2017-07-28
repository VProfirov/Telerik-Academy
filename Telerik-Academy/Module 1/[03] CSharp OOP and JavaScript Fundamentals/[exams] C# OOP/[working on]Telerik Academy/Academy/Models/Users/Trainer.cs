using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Users
{
    using Academy.Models.Contracts;
    using static Utils.Validation.UsersValidator;

    internal class Trainer : ITrainer
    {
        private string username;

        public Trainer(string username, string technologies)
        {
            this.Username = username;
            this.Technologies = technologies.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList(); 
        }

        public string Username
        {
            get => this.username;
            set => this.username = UsernameValidation(value);
        }

        public IList<string> Technologies { get; set; }

        public override string ToString()
        {
            //TODO: impl - output class
            throw new NotImplementedException("Create an Output Class");
        }
    }
}
