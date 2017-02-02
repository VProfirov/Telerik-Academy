namespace Academy.Commands.Listing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Academy.Commands.Contracts;
    using Academy.Core.Contracts;
    using Academy.Models;

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
            var studentsAndTrainers = this.engine.Trainers.Select(x => (IUser)x).ToList();
            studentsAndTrainers.AddRange(this.engine.Students);

            if (this.engine.Trainers.Count == 0 && this.engine.Students.Count == 0)
            {
                throw new ArgumentException("There are no registered users!");
            }
            else
            {
                return string.Join("\n\r", studentsAndTrainers);
            }
        }
    }
}
