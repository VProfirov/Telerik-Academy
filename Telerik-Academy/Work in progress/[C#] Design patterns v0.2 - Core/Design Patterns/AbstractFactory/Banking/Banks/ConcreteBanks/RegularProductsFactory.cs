using AbstractFactory.Banking.BankingProducts;

namespace AbstractFactory.Banking.Banks.ConcreteBanks
{
    public class RegularProductsFactory:IBankingFactory
    {
        public IBankingProduct CreateLoan()
        {
            return new Loan();
        }

        public IBankingProduct CreateCredit()
        {
            return new Credit();
        }
    }
}