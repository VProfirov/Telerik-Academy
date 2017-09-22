using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNetCore
{
    class Car : Automobile
    {
        public Car()
        {

        }
        public Car(string model)
        {
            this.Model = model;
        }

        public Car(string type, bool isMoveable) : base(type, isMoveable)
        {
        }

        public string Model { get; private set; }
    }
}
