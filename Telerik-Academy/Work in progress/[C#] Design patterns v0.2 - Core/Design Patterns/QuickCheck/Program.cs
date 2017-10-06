using System;

namespace QuickCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var loan = new Loan();
//            loan.Balance = 20;
            loan.Draw(50);
            Console.WriteLine(loan.Balance);
        }
    }

    class Loan
    {
//                public decimal Balance { get; set; } = 500;
                public decimal Balance { get; private set; } = 500;
        //        public decimal Balance { get;} = 500;

        public void Draw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
