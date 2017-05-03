using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;

namespace Academy.Models.Academy_Constructs
{
    class Trainer:ITrainer
    {
        public Trainer(string username, string technologies)
        {
            
        }
        public string Username { get; set; }
        public IList<string> Technologies { get; set; }

        public override string ToString()
        {
            return base.ToString();//TODO Output
        }
    }
}
