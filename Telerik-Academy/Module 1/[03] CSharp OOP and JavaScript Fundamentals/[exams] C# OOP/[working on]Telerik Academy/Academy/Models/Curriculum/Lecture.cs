using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Curriculum
{
    using Academy.Models.Contracts;
    using Academy.Models.Utils.Output;
    using static Utils.Validation.CurriculumValidator;

    internal class Lecture : ILecture
    {
        private string name;

        public Lecture(string name, DateTime date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = date;
            this.Trainer = trainer;
        }

        public string Name
        {
            get => this.name;
            set => this.name = LectureNameValidation(value);
        }

        public DateTime Date { get; set; }

        public ITrainer Trainer { get; set; }

        public IList<ILectureResource> Resources { get; } = new List<ILectureResource>();

        public override string ToString()
        {
            return StringFormatOutput.LectureOutput(this);
        }
    }
}
