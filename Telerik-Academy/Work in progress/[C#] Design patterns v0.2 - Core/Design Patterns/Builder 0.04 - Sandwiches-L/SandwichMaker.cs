using System.Runtime.InteropServices.ComTypes;

namespace Sandwiches_L
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
            return builder.GetSandwich();
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