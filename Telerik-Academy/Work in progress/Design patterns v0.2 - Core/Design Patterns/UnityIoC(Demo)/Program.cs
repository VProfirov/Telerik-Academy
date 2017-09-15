using System;
using System.Runtime.InteropServices;
using Microsoft.Practices.Unity;
namespace UnityIoC_Demo_
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();

            container.RegisterType<ICreditCard, MasterCard>();
        }
    }

    public class Visa : ICreditCard
    {
        public string Charge()
        {
            return "Visa.....Visa";
        }

        public int ChargeCount => 0;
    }

    public class MasterCard : ICreditCard
    {
        public string Charge()
        {
            ChargeCount++;
            return "Charging with Master Card";
        }

        public int ChargeCount { get; set; }
    }

    public interface ICreditCard
    {
        string Charge();
        int ChargeCount { get;  }
    }

    public class Shopper
    {
        private readonly ICreditCard creditCard;

        public Shopper(ICreditCard creditCard)
        {
            this.creditCard = creditCard;
        }

        public int ChargesForCurrentCard => creditCard.ChargeCount;
        public void Charge() => Console.WriteLine(creditCard.Charge());
    }
}
