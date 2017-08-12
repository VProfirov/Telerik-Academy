using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    using static Generics.BasicGenerics;
    class Program
    {
        static void Main(string[] args)
        {
            var basicGenDog = new AnimalShelter<Animal<Dog>>();

            var doglist = new List<Animal<Dog>>();
            doglist.Add(new Animal<Dog>());
            doglist.Add(new Animal<Dog>("Pesho",2));

            basicGenDog.AnimaList = doglist;

            foreach (var dog in basicGenDog.AnimaList)
            {
                Console.WriteLine(dog.Name);
                Console.WriteLine(dog.Age);
                Console.WriteLine(dog);
            }
        }
    }
}