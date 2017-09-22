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
//            container.RegisterType<ICreditCard, Visa>(new TransientLifetimeManager()); //==()
//            container.RegisterType<ICreditCard, MasterCard>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICreditCard, MasterCard>();
            container.RegisterType<ICreditCard, Visa>();
            container.RegisterType<ICreditCard, MasterCard>();

            var shopper = container.Resolve<Shopper>();
            shopper.Charge();
            Console.WriteLine(shopper.ChargesForCurrentCard);

            var shopper2 = container.Resolve<Shopper>();
            shopper2.Charge();
            Console.WriteLine(shopper.ChargesForCurrentCard);

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
