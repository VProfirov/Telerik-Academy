using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    class Woman:IOwner
    {
        public string Name { get; }
        public IAnimal WhatAnimalDoYouHave(string command)
        {
            if (command == "Please")
            {
                return new Cat();
            }
            return new Cat();
        }
    }
}
