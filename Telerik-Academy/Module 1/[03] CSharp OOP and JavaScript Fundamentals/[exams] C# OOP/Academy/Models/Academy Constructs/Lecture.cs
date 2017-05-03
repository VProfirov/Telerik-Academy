using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Model_Validator;

namespace Academy.Models.Academy_Constructs
{
    class Lecture : ILecture
    {
        private string name;

        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = DateTime.Parse(date);
            this.Trainer = trainer;
        }

        public string Name
        {
            get => this.name;
            set
            {
                Validator.StringValidation(value,Validator.);
                this.name = value;
            }
        }
        public DateTime Date { get; set; }
        public ITrainer Trainer { get; set; }
        public IList<ILectureResouce> Resouces { get; } = new List<ILectureResouce>();

        public override string ToString()
        {
            return base.ToString();//TODO Output
        }
    }
}
