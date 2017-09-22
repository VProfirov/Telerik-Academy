namespace Sandwiches_L
{
    public class PlatSandwichBuilder:SandwichBuilder
    {
        public override void AddMeatAndCheese()
        {
            sandwich.MeatType = MeatType.beef;
            sandwich.CheeseType = CheeseType.french;
        }

        public override void PrepareBread()
        {
            sandwich.IsToasted = false;
        }

        public override void AddCondiments()
        {
            sandwich.HasMayo = true;
            sandwich.HasMustard = false;
        }

        public override void AddVegetables()
        {
            sandwich.Vegetables.Add("Tomatoes");
            sandwich.Vegetables.Add("Cucumbers");
        }
    }
}