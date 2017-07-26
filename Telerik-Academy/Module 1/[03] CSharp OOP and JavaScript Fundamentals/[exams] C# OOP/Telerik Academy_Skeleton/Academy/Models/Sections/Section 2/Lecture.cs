using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Academy.Models.Contracts;

namespace Academy.Models.Sections.Section_2
{
    class Lecture : ILecture
    {
        public DateTime Date
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IList<ILectureResouce> Resouces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ITrainer Trainer
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
