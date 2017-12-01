namespace Academy.Models.Syllabus
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Academy.Models.Contracts;

    internal class Lecture : ILecture
    {
        private string _name;

        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = DateTime.Parse(date);
            this.Trainer = trainer;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || (value.Length < 5 || value.Length > 30))
                {
                    throw new ArgumentException("Lecture's name should be between 5 and 30 symbols long!");
                }
                this._name = value;
            }
        }

        public DateTime Date { get; set; }

        public ITrainer Trainer { get; set; }

        public IList<ILectureResouce> Resouces { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("  * Lecture: ");
            sb.AppendLine($"   - Name: {this.Name}");
            sb.AppendLine($"   - Date: {this.Date}");
            sb.AppendLine($"   - Trainer username: {this.Trainer.Username}");
            if (Resouces.Count == 0)
            {
                sb.AppendLine("    * There are no resources in this lecture.");
            }
            else
            {
                foreach (var lectureResouce in this.Resouces)
                {
                    sb.AppendLine($"{lectureResouce}");
                }
            }
            return sb.ToString();
        }
    }
}