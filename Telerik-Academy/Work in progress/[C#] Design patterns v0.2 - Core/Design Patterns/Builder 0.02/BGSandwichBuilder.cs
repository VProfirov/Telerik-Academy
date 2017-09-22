namespace Builder_0._02
{
    public class BGSandwichBuilder:SandwichBuilder
    {
        public override void AddingCheese()
        {
            sandwich.CheeseType = CheeseType.bulgarian;
        }

        public override void AddingMeat()
        {
            sandwich.MeatType = MeatType.chicken;
        }

        public override void AddingMustard()
        {
            sandwich.MustardType = MustardType.regular;
        }
    }
}