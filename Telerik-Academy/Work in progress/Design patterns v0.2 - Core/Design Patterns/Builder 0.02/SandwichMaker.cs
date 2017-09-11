namespace Builder_0._02
{
    public class SandwichMaker
    {
        private SandwichBuilder sandwichBuilder;

        public SandwichMaker(SandwichBuilder builder)
        {
            sandwichBuilder = builder;
        }

        public void  BuildSandwich()
        {
            sandwichBuilder.CreateSandwich();

            sandwichBuilder.AddingCheese();
            sandwichBuilder.AddingMeat();
            sandwichBuilder.AddingMustard();
        }

        public Sandwich GetSandwich() => sandwichBuilder.GetSandwich();
//        {
//            return sandwichBuilder.GetSandwich();
//        }

    }
}