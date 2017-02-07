using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_pattern.ConcreteObserver
{
    using Observer_pattern.Observer;
    using Observer_pattern.Subject;

    class Fan:IFan
    {
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"Fan notified. Tweet of {celebrity.FullName}: " + $"{celebrity.Tweet}");
        }
    }
}
