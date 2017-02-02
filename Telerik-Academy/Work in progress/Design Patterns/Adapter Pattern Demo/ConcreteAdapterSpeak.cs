using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_Demo
{
    class ConcreteAdapterSpeak:ISpeak
    {
        public string Speak(string name, int age)
        {
            Console.WriteLine("Concrete Adapter Speak");
            return "I can Speak ... What am I?";
        }
    }
}
