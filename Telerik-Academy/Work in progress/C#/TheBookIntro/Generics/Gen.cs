using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    using static BrokenBasicGenerics;
    public static class Gen
    {
        public static void BG_Gen()
        {
            var basicGenDog = new AnimalShelter<Animal<Dog>>();

            var doglist = new List<Animal<Dog>>();
            doglist.Add(new Animal<Dog>());
            doglist.Add(new Animal<Dog>("Pesho", 2));

            basicGenDog.AnimaList = doglist;

            foreach (var dog in basicGenDog.AnimaList)
            {
                Console.WriteLine(dog.Name);
                Console.WriteLine(dog.Age);
                Console.WriteLine(dog);
            }
        }

        public static void AnimalShelter_Gen()
        {
            var shelter = new Shelter<Dog>();
            shelter.ShelterAnimal(new Dog());
            shelter.ShelterAnimal(new Dog());
            shelter.ShelterAnimal(new Dog());
//            shelter.ShelterAnimal(new Cat());

            Dog D = shelter.Release(0);

            Console.WriteLine(shelter.Length());
        }
    }
}
