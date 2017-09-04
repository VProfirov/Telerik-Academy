using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            new Sandwich(BreadType.dark, false, CheeseType.french, MeatType.chicken, false, false,
                new List<string> {"Tomato"}).Display();

            Console.ReadKey();
        }
    }
}
