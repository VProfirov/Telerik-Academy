using System;

namespace DI_of_IList
{
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var trainer = new Trainer("Pesho","JS,.Net,Ruby");

            trainer.Technologies.Add("added Tech");
            Console.WriteLine(trainer.Technologies);

            foreach (var tech in trainer.Technologies)
            {
                Console.WriteLine(tech);
            }
        }
    }

    class Trainer
    {
        private string username;

        public Trainer(string username, string technologies)
        {
            Username = username;
            Technologies = technologies.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public string Username
        {
            get => this.username;
            set => this.username = value;
        }

        public IList<string> Technologies { get; set; } = new List<string>();
    }
}