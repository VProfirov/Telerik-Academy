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

            Console.WriteLine("----------Trainer Output only, exposition example (if everything was encapsulated to the user-\"outputter\" -----");
            Console.WriteLine(trainer);
        }
    }

    class Trainer:ITrainer
    {
        private string username;
        private ITrainer trainerEA;
        public Trainer(string username, string technologies)
        {
            Username = username;
            Technologies = technologies.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            this.trainerEA = this;
        }

        public string Username
        {
            get => this.username;
            set => this.username = value;
        }

        public IList<string> Technologies { get; set; } = new List<string>();

        public ITrainer TrainerExternalAccess => this.trainerEA;

        public override string ToString()
        {
            return Output.PrintFormat(this.TrainerExternalAccess);
        }
    }

    static class Output
    {
        public static string PrintFormat(ITrainer trainer)
        {
            var tech = trainer.Technologies;
            var message = $"Trainer's name is {trainer.Username} and his main tech is : {tech[0]} ";
            return message;
        }
    }

    interface ITrainer
    {
        string Username { get; set; }

        IList<string> Technologies { get; set; }
    }
}