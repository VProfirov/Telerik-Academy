namespace Builder_0._05
{
    public class FrenchSandwich:SandwichBuilder
    {
        public override void AddMeatAndCheese()
        {
            sandwich.MeatType = MeatType.fish;
            sandwich.CheeseType = CheeseType.french;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.seeds;
            sandwich.IsToasted = true;
        }

        public override void AddCondiments()
        {
            sandwich.HasMayo = false;
            sandwich.HasMustard = true;
        }

        public override void AddVegetables()
        {
            sandwich.Vegetables.Add("Tomatoes");
            sandwich.Vegetables.Add("Onions");
            sandwich.Vegetables.Add("Salad");
        }
    }
}