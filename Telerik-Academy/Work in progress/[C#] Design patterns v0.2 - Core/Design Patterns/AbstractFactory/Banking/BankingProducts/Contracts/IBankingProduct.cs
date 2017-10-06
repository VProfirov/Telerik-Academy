namespace AbstractFactory.Banking.BankingProducts
{
    public interface IBankingProduct
    {
        decimal Balance { get; }

        void Deposit(decimal amount);

        decimal Draw(decimal amount);
    }
}