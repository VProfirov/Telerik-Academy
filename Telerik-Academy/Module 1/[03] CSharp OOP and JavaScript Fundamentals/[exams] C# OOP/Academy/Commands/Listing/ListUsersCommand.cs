using System.Collections.Generic;
using System.Text;
using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using Academy.Models;

namespace Academy.Commands.Listing
{
    class ListUsersCommand:ICommand
    {
        private readonly IAcademyFactory factory;
        private readonly IEngine engine;

        public ListUsersCommand(IAcademyFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }
        public string Execute(IList<string> parameters)
        {
            var listUsers = new List<IUser>();
            listUsers.AddRange(this.engine.Trainers);
            listUsers.AddRange(this.engine.Students);

            var sb = new StringBuilder();
            foreach (var user in listUsers)
            {
                sb.AppendLine(user.ToString());
            }
            return sb.ToString();
        }
    }
}
