using System;
using System.Runtime.InteropServices;

namespace IoCContainer_Demo_
{
    class Program
    {
        static void Main(string[] args)
        {
//            ICreditCard creditCard = new MasterCard();
//            ICreditCard creditCard2 = new Visa();
//            var shopper = new Shopper(creditCard2);

            Reslover resolver = new Reslover();
            var shopper = new Shopper(resolver.ResolveCreditCard());
            shopper.Charge();

            //make a IoC container : 15min ioc
        }
    }

    internal class Reslover
    {
        public ICreditCard ResolveCreditCard()
        {
            if (new Random().Next(2) == 1)
            {
                return new Visa();
            }
            return new MasterCard();
        }
    }

    public class Visa : ICreditCard
    {
        public string Charge()
        {
            return "Chaaaarging Visa";
        }
    }

    public class MasterCard : ICreditCard
    {
        public string Charge()
        {
            return "Swipping the MasterCard!";
        }
    }

    public class Shopper
    {
        private readonly ICreditCard creditCard;

        public Shopper(ICreditCard crC)
        {
            creditCard = crC;
        }

        public void Charge()
        {
            var chargeMessage = creditCard.Charge();
            Console.WriteLine(chargeMessage);
        }
    }

    public interface ICreditCard
    {
        string Charge();
    }
}