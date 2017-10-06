using AbstractFactory.Banking.BankingProducts;

namespace AbstractFactory.Banking.Banks.ConcreteBanks
{
    public class BNB:IBankFactory
    {
        public IBankingProduct CreateLoan()
        {
            throw new System.NotImplementedException();
        }

        public IBankingProduct CreateCredit()
        {
            throw new System.NotImplementedException();
        }
    }
}