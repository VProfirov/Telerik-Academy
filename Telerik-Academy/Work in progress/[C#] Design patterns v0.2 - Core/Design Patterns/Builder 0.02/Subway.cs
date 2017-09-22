using System;
using System.Linq;

namespace Builder_0._02
{
    public static class Subway
    {
        public static Sandwich SandwichOrder(string typeOfSandwich)
        {
            typeOfSandwich = typeOfSandwich.ToLower();
            Sandwich order;
            switch (typeOfSandwich)
            {
                case "bgsandwich":
                    order = ReadyRepeat(new BGSandwichBuilder());
                    break;
                case "mysandwich":
                    order = ReadyRepeat(new MySandwichBuilder());
                    break;
                default:
                    Console.WriteLine("We have no such sandwich");
                    return null;
            }
            return order;
        }

        private static Sandwich ReadyRepeat(SandwichBuilder typeOfSandwichToBuild)
        {
            var sandwichMaker = new SandwichMaker(typeOfSandwichToBuild);
            sandwichMaker.BuildSandwich();
            var sandwich = sandwichMaker.GetSandwich();


            void InfoFormat()
            {
                var sandwichTypeName = typeOfSandwichToBuild.GetType().Name.Replace("Builder", " ");
                Console.WriteLine($"-------  {sandwichTypeName}  -------");
                sandwich.Display();
                Console.WriteLine("_____________________________");

            }
            InfoFormat();

            return sandwich;
        }
    }
}