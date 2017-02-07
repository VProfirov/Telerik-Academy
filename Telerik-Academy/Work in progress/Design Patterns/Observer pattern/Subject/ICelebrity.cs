using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_pattern.Subject
{
    using Observer_pattern.Observer;

    interface ICelebrity
    {
        string FullName { get; }

        string Tweet { get; }

        void Notify(string tweet);

        void AddFolower(IFan fan);

        void RemoveFollower(IFan fan);
    }
}
