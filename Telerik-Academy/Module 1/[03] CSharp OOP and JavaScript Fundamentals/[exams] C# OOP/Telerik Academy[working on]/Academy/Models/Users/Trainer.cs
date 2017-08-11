using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Users
{
    using Academy.Models.Contracts;
    using Academy.Models.Utils.Output;
    using static Utils.Validation.UsersValidator;

    internal class Trainer : ITrainer
    {
        private string username;

        public Trainer(string username, IList<string> technologies)
        {
            this.Username = username;
            this.Technologies = technologies;
        }

        public string Username
        {
            get => this.username;
            set => this.username = UsernameValidation(value);
        }

        public IList<string> Technologies { get; set; }

        public override string ToString()
        {
            return StringFormatOutput.TrainerOutput(this);
        }
    }
}
