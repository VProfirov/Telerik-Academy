using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Academy.Models.Contracts;

namespace Academy.Models.Sections.Section_1
{
    class Trainer : ITrainer
    {
        private string _userName;

        public IList<string> Technologies { get; set; }

        //TODO: VP: AcademyFactory to Implement ctor
        public Trainer(string username, string technologies)
        {
            this.Username = username;
            this.Technologies = AddTechnologies(technologies);
        }
        
        public string Username
        {
            get
            {
                return _userName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) 
                    ||(value.Length<3
                    || value.Length>16))
                {
                    throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
                }
                this._userName = value;
            }
        }

        private IList<string> AddTechnologies(string technologies)
        {
            IList<string> techList = new List<string>();
            techList = technologies.Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();//ToList() no function here - more of a clarification
            return techList;
        }

        public override string ToString()
        {
            StringBuilder printBuilder = new StringBuilder();
            printBuilder.AppendLine("* Trainer:");
            printBuilder.AppendLine($" - Username: {this.Username}");

            // Listing of <tehcnologies>
            printBuilder.Append($" - Technologies:");
            var count = this.Technologies.Count();
            foreach (var tech in this.Technologies)
            {
                printBuilder.Append($" {tech}");
                if (--count>0)
                {
                    printBuilder.Append(";");
                }
            }
            printBuilder.AppendLine();
            
            string message = printBuilder.ToString();
            return message;
        }
    }
}
