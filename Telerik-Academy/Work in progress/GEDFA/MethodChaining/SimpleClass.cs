using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodChaining
{
    class SimpleClass
    {
        public int Age { get; private set; }

        public string Name { get; private set; }

        public string Greet { get; private set; }

        public SimpleClass Age10()
        {
            Age += 10;
            return this;
        }

        public SimpleClass MyInfo(int change)
        {
            Greet = $"My name is {this.Name} and I am {this.Age += change}";
            return this;
        }

        public override string ToString()
        {
            return Greet;
        }
    }
}
