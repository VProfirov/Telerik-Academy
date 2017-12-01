using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Core.Commands
{
    public class ListOlympiansCommand : Command, ICommand
    {
        private string command;

        public ListOlympiansCommand(IList<string> commandParameters)
            : base(commandParameters)
        {
            if (Committee.Olympians.Count == 0)
            {
                Console.Write($"{GlobalConstants.NoOlympiansAdded}");
            }

            this.command = string.Join(" ", commandParameters);
        }


        public override string Execute()
        {
            var commandTokens = command.Split(' ').ToArray();
            var commandOutput = new StringBuilder();
            var comittes = this.Committee.Olympians.ToList();

            if (comittes.Count == 0)
            {
                
            }
            else if (commandTokens.Length == 0)
            {
                comittes = comittes.OrderBy(x => x.FirstName).ToList();
            }
            else if (commandTokens.Length == 1)
            {
                if (commandTokens[0] == "firstname")
                {
                    comittes = comittes.OrderBy(x => x.FirstName).ToList();
                    commandOutput.AppendLine($"Sorted by [key: firstname] in [order: asc]");
                }
                else
                {
                    comittes = comittes.OrderBy(x => x.LastName).ToList();
                    commandOutput.AppendLine("Sorted by [key: lastname] in [order: asc]");
                }
            }
            else if (commandTokens.Length == 2)
            {
                if (commandTokens[0] == "firstname")
                {
                    comittes = comittes.OrderByDescending(x => x.FirstName).ToList();
                    commandOutput.AppendLine("Sorted by [key: firstname] in [order: desc]");
                }
                else
                {
                    comittes = comittes.OrderByDescending(x => x.LastName).ToList();
                    commandOutput.AppendLine("Sorted by [key: lastname] in [order: desc]");
                }
            }
            else
            {
                throw new ArgumentException(GlobalConstants.ParametersCountInvalid);
            }

            foreach (var olympian in comittes)
            {
                commandOutput.AppendLine(olympian.ToString());
            }

            return commandOutput.ToString();
        }

    }
}
