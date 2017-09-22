using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.GetCustomAttributes<SampleAttribute>().Count() > 0
                select t;

            foreach (var t in type)
            {
                Console.WriteLine(t.GetProperties());
                Console.WriteLine(t.Name);
                
            }
        }
    }
    [AttributeUsage(AttributeTargets.Class)]
    public class SampleAttribute : Attribute
    {
        public string Name { get; set; }
        public int Version { get; set; }
    }
    [Sample(Name = "John", Version = 1)]
    public class SampleClass
    {
        public int IntValProp { get; set; }
        public string StringValProp { get; set; }

        public void Method()
        {
        }
    }
}
