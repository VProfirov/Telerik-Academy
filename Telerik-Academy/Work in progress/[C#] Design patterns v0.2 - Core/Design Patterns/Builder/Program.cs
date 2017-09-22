using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1. Too many parameters
            //            new Sandwich(BreadType.dark, true, CheeseType.french, MeatType.chicken, false, false,
            //                new List<string> {"Tomato"}).Display();

            //Problem 2. Order dependant - we have no control of the order of the creation
                // no validation controll through the steps, etc
            // still //Problem 1. Too many parameters to set
            //            var sandwich = new Sandwich();
            // set prop 1by1 - but it is cumbersome

            //Problem 3. Different types of builds / sandwiches
//            var builder = new MySandwichBuilder();
//            builder.CreateSandwich();
//            var sandwich = builder.GetSandwich();
//            sandwich.Display();

            // We need common interface -> abstract interface class : SandwichBuilder

            //Final:
            Console.WriteLine("---------Sandwich----------");
            var sandwichMaker = new SandwichMaker(new MySandwichBuilder());
            sandwichMaker.BuildSandwich();
            var sandwich = sandwichMaker.GetSandwich();
            sandwich.Display();

            Console.WriteLine("---------Sandwich----------");
            var sandwichMaker2 = new SandwichMaker(new ClubSandwichBuilder());
            sandwichMaker2.BuildSandwich();
            var sandwich2 = sandwichMaker2.GetSandwich();
            sandwich2.Display();

            //this in a way can be put in a Factory 
        }
    }
}
