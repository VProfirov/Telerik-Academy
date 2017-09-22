using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace IoCContainer_Demo_
{
    class Program
    {
        static void Main(string[] args)
        {
            //            ICreditCard creditCard = new MasterCard();
            //            ICreditCard creditCard2 = new Visa();
            //            var shopper = new Shopper(creditCard2);

//            RandomReslover resolver = new RandomReslover();
//            var shopper = new Shopper(resolver.ResolveCreditCard());
            
            var resolver = new Resolver();
            resolver.Register<Shopper,Shopper>();
            resolver.Register<ICreditCard,MasterCard>();
            resolver.Register<ICreditCard,Visa>();
            var shopper = resolver.Resolve<Shopper>();
            shopper.Charge();

            //make a IoC container : 15min ioc
        }
    }

    public class Resolver
    {
        private Dictionary<Type,Type> dependancyMap = new Dictionary<Type, Type>();
        //seves as syntactic sugar
        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        private object Resolve(Type typeToResolve)
        {
            Type resolvedType = null;
            try
            {
                resolvedType = dependancyMap[typeToResolve];
            }
            catch 
            {
                throw new ArgumentException($"Can't resolve the type {typeToResolve}");
            }

            var firstConstructor = resolvedType.GetConstructors().First();
            var constructorParameters = firstConstructor.GetParameters();
//            if (!constructorParameters.Any())
            if(constructorParameters.Length == 0)
            {
                return Activator.CreateInstance(resolvedType);
            }

            IList<object> parameters = new List<object>();
            foreach (var parameterToResolve in constructorParameters)
            {
                parameters.Add(Resolve(parameterToResolve.ParameterType));//?Resolve call: why ?
                //NOTE: It chains out a tree recursively that ends "Activating" (Acrivator.CreateInstance(resolvedType) the sub types with no params and then up the chain use the params with that defaulted objects-params)
            }
            return firstConstructor.Invoke(parameters.ToArray());
        }

        public void Register<TFrom,TTo>()
        {
            dependancyMap.Add(typeof(TFrom),typeof(TTo));
        }
    }


    internal class RandomReslover
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

        public Shopper(ICreditCard crC)//manual injection
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