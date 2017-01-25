namespace Academy.Models.Academy_Staff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Academy.Models.Contracts;

    internal class Trainer : ITrainer
    {
        private IList<string> _technologies;
        private string _username;

        public Trainer(string username, string technologies)
        {
            this.Username = username;
            this.Technologies = technologies.Split(',');
        }

        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
                }
                this._username = value;
            }
        }

        public IList<string> Technologies
        {
            get
            {
                return this._technologies;
            }
            set
            {
                this._technologies = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"* Trainer:");
            sb.AppendLine($" - Username: {this.Username}");
            sb.Append($" - Technologies:");
            foreach (var technology in this.Technologies)
            {
                sb.Append($" {technology};");
            }
            sb.AppendLine();

            return sb.ToString();
        }
    }
}