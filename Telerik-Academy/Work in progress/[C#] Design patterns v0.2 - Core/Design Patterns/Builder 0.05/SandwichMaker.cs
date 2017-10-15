using System;

namespace Builder_0._05
{
    public class SandwichMaker
    {
        private SandwichBuilder builder;

        public SandwichMaker(SandwichBuilder builder)
        {
            this.builder = builder;
        }

        public Sandwich GetSandwich()
        {
            return builder.GeSandwich();
        }

        public void BuildSandwich()
        {
            builder.CreateSandwich();

            builder.PrepareBread();
            builder.AddMeatAndCheese();
            builder.AddVegetables();
            builder.AddCondiments();
        }
    }
}