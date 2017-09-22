using System.Collections.Generic;

namespace Sandwiches_L
{
    public class GoldSandwichBuilder:SandwichBuilder
    {
        public override void AddMeatAndCheese()
        {
            sandwich.MeatType = MeatType.chicken;
            sandwich.CheeseType = CheeseType.bulgarian;
        }

        public override void PrepareBread()
        {
            sandwich.IsToasted = true;
        }

        public override void AddCondiments()
        {
            sandwich.HasMayo = false;
            sandwich.HasMustard = true;
        }

        public override void AddVegetables()
        {
            sandwich.Vegetables.Add("Pickles");
            sandwich.Vegetables.Add("Onions");
        }
    }
}