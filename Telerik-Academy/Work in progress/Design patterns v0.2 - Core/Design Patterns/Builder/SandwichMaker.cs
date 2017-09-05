namespace Builder
{
    public class SandwichMaker
    {
        private readonly SandwichBuilder builder;
        //SandwichBuilder as common interface of the different builders
        public SandwichMaker(SandwichBuilder builder)
        {
            this.builder = builder;
        }

        //The different ways of preparation - order - etc ... => by using a form of factory method taking a type (dynamic type => dinamic factory ...)
            // NOT what they will have - that is job of the different sandwiches(products)
        public void BuildSandwich()
        {
            builder.CreateSandwich();

            builder.PrepareBread();
            builder.ApplyMeatAndCheese();
            builder.ApplyVegetables();
            builder.AddCondiments();
        }

        //getting out the already made sandwich
        public Sandwich GetSandwich()
        {
            return builder.GetSandwich();
        }

        // !NB the 2step BuldSandwich() and GetSandwich() looks like reversed Factory : preping data; returning and instance => that constructs/builds itself
    }
}