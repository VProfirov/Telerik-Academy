using System;

namespace Sandwiches_L
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new SandwichMaker(new PlatSandwichBuilder());
//            var shop = new SandwichMaker(new GoldSandwichBuilder());
            shop.BuildSandwich();
            var sandwich = shop.GetSandwich();
            sandwich.Display();

            Console.WriteLine("Director --|> Builder <|-- Concrete Bulder <|---- Sandwich");
        }
    }
}
