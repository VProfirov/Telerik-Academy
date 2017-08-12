using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class BasicGenerics
    {
        public class AnimalShelter<T>
        {
            public IList<T> AnimaList { get; set; } = new List<T>();
        }

        public class Animal<T>
        {
            public Animal() : this("Sharo", 0)
            {
            }
            public Animal(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public int Age { get; set; }

            public string Name { get; set; }

            public override string ToString()
            {
                return $"I am a {this.GetType().Name} and my name is {this.Name} - {this.Age} years old";
            }
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
