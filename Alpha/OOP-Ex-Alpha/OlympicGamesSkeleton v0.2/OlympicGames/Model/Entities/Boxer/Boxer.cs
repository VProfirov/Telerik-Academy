using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;

namespace OlympicGames.Model.Entities
{
    public class Boxer : Olympian, IBoxer
    {
        public BoxingCategory Category { get; }

        public int Wins { get; }

        public int Losses { get; }

        public Boxer(string firstName, string lastName, string country, string category, int wins,
            int losses) : base(firstName, lastName, country)
        {
            Category.ValidateIfNull();
            Wins.ValidateIfNull();
            Wins.ValidateMinAndMaxNumber(0, 100);
            Losses.ValidateIfNull();
            Losses.ValidateMinAndMaxNumber(0, 100);

            BoxingCategory boxingCategory;

            if (category == "heavyweight")
            {
                boxingCategory = BoxingCategory.Heavyweight;
            }
            else if (category == "lightweight")
            {
                boxingCategory = BoxingCategory.Lightweight;
            }
            else if (category == "flyweight")
            {
                boxingCategory = BoxingCategory.Flyweight;
            }
            else if (category == "featherweight")
            {
                boxingCategory = BoxingCategory.Featherweight;
            }
            else
            {
                boxingCategory = BoxingCategory.Middleweight;                
            }

            this.Category = boxingCategory;
            this.Wins = wins;
            this.Losses = losses;           
        }

        public override string ToString()
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return $@"BOXER: {FirstName} {LastName} from {Country}
Category: {textInfo.ToTitleCase(this.Category.ToString())}
Wins: {Wins}
Losses: {Losses}";
        }
    }
}
