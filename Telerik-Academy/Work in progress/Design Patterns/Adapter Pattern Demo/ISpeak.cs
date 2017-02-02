using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_Demo
{
    interface ISpeak
    {
        string Speak(string name,int age);
    }
}
