using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    class Program
    {
        static void Main(string[] args)
        {
            var petFactory = new Human();
            var owner = petFactory.GetMeOwner("woman");
            var pet = owner.WhatAnimalDoYouHave("please");
            pet.Name = "jj";
            Console.WriteLine($"My name is {pet.Name} and i can :");
            pet.Jump();
        }
    }
}
