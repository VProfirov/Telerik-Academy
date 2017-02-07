using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_pattern.ConcreteSubject
{
    using Observer_pattern.ConcreteObserver;
    using Observer_pattern.Observer;
    using Observer_pattern.Subject;
    class GCloony:ICelebrity
    {
        private readonly List<IFan> _fans = new List<IFan>();
        private string _tweet;
        public GCloony(string defaultTweet)
        {
            _tweet = defaultTweet;
        }

        public string FullName => "George Cloony";

        public string Tweet {
            get
            {
                return this._tweet;
            }
            set
            {
                Notify(value);
            }
        }

        public void Notify(string tweet)
        {
            this._tweet = tweet;
            foreach (var fan in this._fans)
            {
                fan.Update(this);
            }

        }

        public void AddFolower(IFan fan)
        {
            this._fans.Add(fan);
        }

        public void RemoveFollower(IFan fan)
        {
            this._fans.Remove(fan);
        }
    }
}
