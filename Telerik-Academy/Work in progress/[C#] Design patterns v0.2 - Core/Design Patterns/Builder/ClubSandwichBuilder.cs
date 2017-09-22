using System.Collections.Generic;

namespace Builder
{
    public class ClubSandwichBuilder:SandwichBuilder
    {
       public override void AddCondiments()
        {
            // for each part of the cration process we need - this step allows us this separation and abstraction
            //maybe validation ; maybe checking ; decision making
            sandwich.HasMayo = true;
            sandwich.HasMustard = true;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Onion","Garlic" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.CheeseType = CheeseType.bulgarian;
            sandwich.MeatType = MeatType.beef;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.seeds;
            sandwich.IsToasted = false;
        }
    }
}