using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;

namespace Academy.Models.Academy_Constructs
{
    class Lecture : ILecture
    {
        public Lecture(string name, string date, ITrainer trainer)
        {
            
        }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public ITrainer Trainer { get; set; }
        public IList<ILectureResouce> Resouces { get; }

        public override string ToString()
        {
            return base.ToString();//TODO Output
        }
    }
}
