using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Model.Entities
{
    public abstract class Olympian : IOlympian
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string Country { get; }


        public Olympian(string firstName, string lastName, string country)
        {
            firstName.ValidateMinAndMaxLength(2, 20);
            lastName.ValidateMinAndMaxLength(2, 20);
            country.ValidateMinAndMaxLength(3,25);

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
        }
    }
}
