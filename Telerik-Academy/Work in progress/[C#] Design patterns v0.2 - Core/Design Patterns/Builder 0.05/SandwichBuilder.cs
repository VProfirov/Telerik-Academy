namespace Builder_0._05
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public void CreateSandwich()
        {
            sandwich = new Sandwich();
        }

        public Sandwich GeSandwich()
        {
            return sandwich;
        }

        public abstract void AddMeatAndCheese();
        public abstract void PrepareBread();
        public abstract void AddCondiments();
        public abstract void AddVegetables();
    }
}