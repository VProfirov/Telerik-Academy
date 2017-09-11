namespace Builder_0._01
{
    public abstract class ShampooBuilder
    {
        protected Shampoo shampoo;
        public Shampoo GetShampoo()
        {
            return shampoo;
        }

        public void CreateShampoo()
        {
            shampoo = new Shampoo();
        }

        public abstract void AddVitamins();
        public abstract void AddAroma();
        public abstract void GenderMarket();
    }
}