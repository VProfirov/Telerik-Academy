using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class CustomExtensionMethods
    {
        public static void Greet(this CustomClass person)
        {
            Console.WriteLine($"I am {person.Name} and my hobby is {person.Hobby}"); 
        }

        public static string GreetBuilder(this CustomClass person)
        {
            return $"Hi my name is {person.Name} and I am {person.Age} (love {person.Hobby})";
        }
    }
}
