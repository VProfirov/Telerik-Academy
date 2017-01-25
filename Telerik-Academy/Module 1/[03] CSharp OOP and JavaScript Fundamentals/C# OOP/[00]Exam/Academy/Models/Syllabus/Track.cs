using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Syllabus.Util;

namespace Academy.Models.Syllabus
{
    // not needed IStudent must be wrong to set a Track type to hold 1 value of the Track's name
    public class Track:ITrack
    {
        private string _name;

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value)
                   || value != "Frontend"
                   || value != "Dev"
                   || value != "None")
                {
                    throw new ArgumentException("The provided track is not valid!");
                }
                this._name = value;
            }
        }

        public Track(string track)
        {
            this.Name = track;
        }


    }
}
