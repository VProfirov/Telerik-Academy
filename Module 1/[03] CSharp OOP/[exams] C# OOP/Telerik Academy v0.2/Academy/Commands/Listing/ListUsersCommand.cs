using System.Collections.Generic;
using System.Text;
using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using Academy.Models;
using Academy.Models.Validation;

namespace Academy.Commands.Listing
{
    class ListUsersCommand : ICommand
    {
        private readonly IAcademyFactory _factory;
        private readonly IEngine _engine;

        public ListUsersCommand(IAcademyFactory factory, IEngine engine)
        {
            this._factory = factory;
            this._engine = engine;
        }
        public string Execute(IList<string> parameters)
        {
            var listUsers = new List<IUser>();
            listUsers.AddRange(this._engine.Trainers);
            listUsers.AddRange(this._engine.Students);

            Validator.EmptyUserListValidation(listUsers);

            var sb = new StringBuilder();
            foreach (var user in listUsers)
            {
                sb.AppendLine(user.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
