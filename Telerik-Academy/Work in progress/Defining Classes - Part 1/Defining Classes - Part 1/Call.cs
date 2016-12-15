using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class Call
    {
        public DateTime Date { get; set; }
        public TimeSpan Time{ get; set; }
        public List<string> CallsMadeTo { get; set; }
        public TimeSpan DurationInSec { get; set; }
    }
}
