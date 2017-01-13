using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Engine
    {
        static void Main(string[] args)
        {
            CustomClass person = new CustomClass(15,"Tosho") {Hobby = "GG"};

            person.Greet();
            
            Console.WriteLine(person.GreetBuilder());

            string lorem = "lorem";
            Console.WriteLine(lorem.PoliteToString());
        }
    }
}
