namespace Builder_0._02
{
    public class MySandwichBuilder:SandwichBuilder
    {
        public override void AddingCheese()
        {
            sandwich.CheeseType = CheeseType.american;
        }

        public override void AddingMeat()
        {
            sandwich.MeatType = MeatType.beef;
        }

        public override void AddingMustard()
        {
            sandwich.MustardType = MustardType.dijon;
        }
    }
}