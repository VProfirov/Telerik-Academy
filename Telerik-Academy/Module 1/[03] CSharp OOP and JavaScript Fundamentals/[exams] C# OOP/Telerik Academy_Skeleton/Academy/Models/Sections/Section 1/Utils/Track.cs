using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Sections.Section_2;

namespace Academy.Models.Sections.Section_1.Utils
{
    public class Track : ITrack
    {
        private string _name;

        //TODO: VP:implement default ctor
        public Track(string name)
        {
            this.Name = name;           
        }
        //Track that is either Frontend, Dev or None
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (string.IsNullOrEmpty(value)||
                    (value != "Frontend"
                    || value != "Dev"
                    || value != "None"))
                {
                    throw new ArgumentException("The provided track is not valid!");
                }
                this._name = value;
            }
        }
    }
}
