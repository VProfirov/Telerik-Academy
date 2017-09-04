using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    class Man:IOwner
    {
        public string Name { get; }
        public IAnimal WhatAnimalDoYouHave(string please)
        {
            if (please == "please")
            {
                return new Cat();
            }
            else
            {
                return new Dog();
            }
        }
    }
}
