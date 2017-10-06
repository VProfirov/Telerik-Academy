using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var shelter = new AnimalShelter();
            var animal = shelter.ShelterAnAnimal("doG");
            //implement sheltering : add it to the shelter
        }
    }

    interface IShelter
    {
        List<Animal> ShelteredAnimals { get; set; }
//        T Adopt<T>();
    }

    class AnimalShelter:IShelter
    {
        public Animal ShelterAnAnimal(string animal)
        {
            Animal shelteredAnimal = null;
            switch (animal.ToLower())
            {
                case "cat": shelteredAnimal =  new Cat();
                    break;
                case "dog": shelteredAnimal = new Dog();
                    break;
                default: Console.WriteLine("No such beast");break;
            }
            return shelteredAnimal;
        }

        public Animal ShelterABeast(string animal)
        {
            switch (animal.ToLower())
            {
                case "cat": return new Cat();
                case "dog": return new Dog();
                default: throw new ArgumentException();
            }
        }

        public List<Animal> ShelteredAnimals { get; set; }
    }

    class Cat:Animal
    {
        
    }

    class Dog:Animal
    {
        
    }

    internal abstract class Animal
    {
        private string Name;
    }
}
