namespace Sandwiches_L
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public void CreateSandwich()
        {
            sandwich = new Sandwich();
        }

        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public abstract void AddMeatAndCheese();
        public abstract void PrepareBread();
        public abstract void AddCondiments();
        public abstract void AddVegetables();
    }
}