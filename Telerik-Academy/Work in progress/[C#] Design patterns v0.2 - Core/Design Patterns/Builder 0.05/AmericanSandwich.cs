namespace Builder_0._05
{
    public class AmericanSandwich:SandwichBuilder
    {
        public override void AddMeatAndCheese()
        {
            sandwich.MeatType = MeatType.beef;
            sandwich.CheeseType = CheeseType.normal;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.white;
            sandwich.IsToasted = true;
        }

        public override void AddCondiments()
        {
            sandwich.HasMayo = true;
            sandwich.HasMustard = true;
        }

        public override void AddVegetables()
        {
            sandwich.Vegetables.Add("Tomatoes");
            sandwich.Vegetables.Add("Salad");
        }
    }
}