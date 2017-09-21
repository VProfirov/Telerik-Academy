using System;
using System.ComponentModel.DataAnnotations;

namespace InheritanceProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new SubClass();
            b.Name = "12345";
            Console.WriteLine(b.Name);
        }
    }

    public abstract class AbstractClass
    {
        public abstract string Name { get; set; }
    }

    public class BaseClass
    {
        private  string name;

        public string Name
        {
            get => name;
            set
            {
//                if (value.Length >= 3 && value.Length <=7)
//                {
//                }
                name = value;

                Console.WriteLine("BaseClass Name(3>=name<=7)");
            }
        }
    }

    public class SubClass:BaseClass
    {
        private string name;

        public virtual string Name
        {
            get => name;
            set
            {
//                if (value.Length >= 5 && value.Length <= 10)
//                {
//                }
                name = value;

                Console.WriteLine("SubClass Name(5 >= name <= 10)");

            }
        }
    }

    public class DerivedClass:SubClass
    {
        private string name;

        public override string Name
        {
            get => name;
            set
            {
//                if (value.Length >= 20 && value.Length <= 30)
//                {
//                }
                name = value;
                Console.WriteLine("DerivedClass Name( 20 >= name <= 30)");
            }
        }
    }
}
