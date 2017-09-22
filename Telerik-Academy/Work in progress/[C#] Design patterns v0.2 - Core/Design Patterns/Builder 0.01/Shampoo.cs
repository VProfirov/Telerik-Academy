using System;

namespace Builder_0._01
{
    public class Shampoo
    {
        public AromaType AromaType { get; set; }
        public string Vitamins { get; set; }
        public GenderGroup GenderGroup { get; set; }

        public void DisplayProduct()
        {
            Console.WriteLine($"Shampoo for {GenderGroup} with aroma of {AromaType} has:");
            Console.WriteLine($"{Vitamins} vitamins");
        }
    }

    public enum AromaType
    {
        Rose,
        Citron,
        Orange
    }

    public enum GenderGroup
    {
        men,
        women
    }
}