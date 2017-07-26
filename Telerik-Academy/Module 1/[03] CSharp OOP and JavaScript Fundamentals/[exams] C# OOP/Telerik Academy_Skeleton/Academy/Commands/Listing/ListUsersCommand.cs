using System;
using System.Collections.Generic;
using Academy.Commands.Contracts;
using Academy.Core.Contracts;
namespace Academy.Commands.Listing
{
    public class ListUsersCommand : ICommand
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
            var seasonId = parameters[0];
            var students = this.engine.Students[int.Parse(seasonId)];
            var trainers = this.engine.Trainers[int.Parse(seasonId)];

            return students.ToString();
        }
    }    
}
