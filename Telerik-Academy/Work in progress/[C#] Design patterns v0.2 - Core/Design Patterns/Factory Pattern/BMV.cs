using System;

namespace Factory_Pattern
{
    public class BMV:IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine($"BMV ON");
        }

        public void TurnOff()
        {
            Console.WriteLine($"BMV OFF");
        }
    }
}