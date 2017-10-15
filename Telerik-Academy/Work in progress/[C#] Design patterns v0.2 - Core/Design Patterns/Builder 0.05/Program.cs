using System;

namespace Builder_0._05
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new SandwichMaker(new FrenchSandwich());
            builder.BuildSandwich();
            var sandwich = builder.GetSandwich();
            sandwich.Display();
        }
    }
}
