using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class CustomClass
    {
        public int Age { get; private set; }

        public string Name { get; private set; }

        public string Hobby { get; set; }

        public CustomClass()
        {
            
        }
        public CustomClass(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        public CustomClass(int age, string name, string hobby):this(age,name)
        {
            this.Hobby = hobby;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
