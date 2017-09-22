using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNetCore
{
    class Automobile : Vehicle
    {
        public Automobile()
        {

        }
        public Automobile(bool isMoveable) : base(isMoveable)
        {
        }

        public Automobile(string type, bool isMoveable) : base(isMoveable)
        {
            if (type.ToLower() == "electric")
            {
                isElectric = true;
            }
            else
            {
                isGasoline = true;
            }

        }

        public bool isElectric { get; private set; }

        public bool isGasoline { get; private set; }
    }
}
