using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    interface IOwner
    {
        string Name { get; }
        IAnimal WhatAnimalDoYouHave(string command);
    }
}
