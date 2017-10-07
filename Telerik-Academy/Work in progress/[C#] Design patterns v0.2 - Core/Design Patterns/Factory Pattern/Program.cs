using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main()
        {
            var carName = Console.ReadLine();

            AutoFactory factory = new AutoFactory();
            IAuto car = factory.CreateInstance(carName);

            car.TurnOn();
            car.TurnOff();
        }
    }
}
