using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal<Cat> dog = new Animal<Cat>();
            Console.WriteLine(dog.Name);
        }

        public class AnimalShelter<T>
        {
            public IList<T> AnimaList { get; set; } = new List<T>();
        }

        public class Animal<T>
        {
            public Animal():this("Sharo",0)
            {
            }
            public Animal(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public int Age { get; set; }

            public string Name { get; set; }
        }

        public class Dog
        {
            public override string ToString()
            {
                return $"Bou";
            }
        }

        public class Cat
        {
            public override string ToString()
            {
                return $"Mauuu";
            }
        }
    }
}