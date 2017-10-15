using System;
using System.Collections.Generic;

namespace Builder_0._05
{
    public class Sandwich
    {
        public BreadType BreadType { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public bool IsToasted { get; set; }
        public bool HasMustard { get; set; }
        public bool HasMayo { get; set; }
        public IList<string> Vegetables { get; set; } = new List<string>();

        //Problem 1. Too many parameters
        //        public Sandwich(BreadType breadType,bool isToasted, CheeseType cheeseType,MeatType meatType,bool hasMustard,bool hasMayo,IList<string> vegetabList)
        //        {
        //            BreadType = breadType;
        //            IsToasted = isToasted;
        //            CheeseType = cheeseType;
        //            MeatType = meatType;
        //            HasMustard = hasMustard;
        //            HasMayo = hasMayo;
        //            Vegetables = vegetabList;
        //        }

        public void Display()
        {
            Console.WriteLine($"Sandwitch on {this.BreadType} bread");
            if (IsToasted)
            {
                Console.WriteLine("Toasted");
            }
            if (HasMayo)
            {
                Console.WriteLine("With Mayo");
            }
            if (HasMustard)
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