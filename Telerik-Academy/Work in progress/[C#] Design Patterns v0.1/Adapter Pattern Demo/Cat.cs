using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_Demo
{
    class Cat:ISpeak
    {
        public string Speak(string name, int age)
        {
            Console.WriteLine("Cat's Default Speak");
            return string.Format("My name is {0} and my age is {1}",name,age);
        }
    }
}
