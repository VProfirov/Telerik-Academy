using AbstractFactory.Banking.BankingProducts;

namespace AbstractFactory.Banking.Banks.ConcreteBanks
{
    public class StudentProductsFactory:IBankingFactory
    {
        public IBankingProduct CreateLoan()
        {
            return new StudentLoan();
        }

        public IBankingProduct CreateCredit()
        {
            return new StudentCredit();
        }
    }
}