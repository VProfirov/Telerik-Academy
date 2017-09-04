using System;
using System.Collections.Generic;

namespace Builder
{
    public class Sandwiches
    {
        public BreadType BreadType { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public bool IsToasted { get; set; }
        public bool hasMustard { get; set; }
        public bool hasMayo { get; set; }
        public List<string> Vegetables;

        public Sandwiches()
        {
            
        }

        public void Display()
        {
            Console.WriteLine($"Sandwitch on {this.BreadType}");
            if (IsToasted)
            {
                Console.WriteLine("Toasted");
            }
            if (hasMayo)
            {
                Console.WriteLine("With Mayo");
            }
            if (hasMustard)
            {
                Console.WriteLine("With Mustard");
            }
            Console.WriteLine($"Meat: {this.MeatType}");
            Console.WriteLine($"Cheese: {this.CheeseType}");
            Console.WriteLine("Vegetables: ");
            foreach (var vegetable in Vegetables)
            {
                Console.WriteLine($" {vegetable}");
            }
        }
    }

    public enum CheeseType
    {
        normal,
        french,
        bulgarian
    }

    public enum BreadType
    {
        dark,
        white,
        seeds
    }

    public enum MeatType
    {
        chicken,
        beef,
        fish
    }
}