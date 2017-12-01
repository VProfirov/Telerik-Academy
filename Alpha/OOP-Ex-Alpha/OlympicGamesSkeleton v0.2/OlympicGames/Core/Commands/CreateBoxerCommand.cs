using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;
using OlympicGames.Core.Factories;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : Command, ICommand
    {
        private string command;

        public CreateBoxerCommand(IList<string> commandParameters)
            : base(commandParameters)
        {
            commandParameters.ValidateIfNull();
            this.command = string.Join(" ", CommandParameters);
        }

        public override string Execute()
        {
            var commandTokens = command
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            var firstName = commandTokens[0];
            firstName.ValidateMinAndMaxLength(2, 20);
            var lastName = commandTokens[1];
            lastName.ValidateMinAndMaxLength(2, 20);
            var country = commandTokens[2];
            country.ValidateMinAndMaxLength(3, 25);
            var category = commandTokens[3];
            category.ValidateIfNull();
            var wins = int.Parse(commandTokens[4]);
            wins.ValidateMinAndMaxNumber(0, 100);
            var losses = int.Parse(commandTokens[5]);
            losses.ValidateMinAndMaxNumber(0, 100);

            Committee.Olympians.Add(OlympicsFactory.Instance.CreateBoxer(firstName, lastName, country, category, wins, losses));

CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            var commandMesssage = $@"Created Boxer
BOXER: {firstName} {lastName} from {country}
Category: {textInfo.ToTitleCase(category)}
Wins: {wins}
Losses: {losses}";

            return commandMesssage;
        }
    }
}
