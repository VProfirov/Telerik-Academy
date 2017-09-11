namespace Builder_0._01
{
    public class ShampooMaker
    {
        private ShampooBuilder shampooBuilder;

        public ShampooMaker(ShampooBuilder shampooBuilder)
        {
            this.shampooBuilder = shampooBuilder;
        }

        public Shampoo GetShampoo()
        {
            return shampooBuilder.GetShampoo();
        }

        public void BuildShampoo()
        {
            shampooBuilder.CreateShampoo();

            shampooBuilder.AddVitamins();
            shampooBuilder.AddAroma();
            shampooBuilder.GenderMarket();
        }
    }
}