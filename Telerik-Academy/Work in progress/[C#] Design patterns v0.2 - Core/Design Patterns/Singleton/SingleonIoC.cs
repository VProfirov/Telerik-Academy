using System;
using System.Collections.Generic;
using System.Linq;

namespace Singleton
{
    public class SingleonIoC
    {
        private Dictionary<Type,Type> dependencyMap = new Dictionary<Type, Type>();

        public T Resolve<T>()
        {
            return (T) Resolve(typeof(T));
        }

        private object Resolve(Type typeToResolve)
        {
            Type resolvedType = null;
            try
            {
                resolvedType = dependencyMap[typeToResolve];
            }
            catch
            {
                throw new ArgumentException($"Problem with the resolving the type {typeToResolve}");
            }

            // ioc for Interface DI

            var constructorToResolve = typeToResolve.GetConstructors().First();
//            var constructorToResolve = typeToResolve.GetConstructors().FirstOrDefault();
            var constructorParameters = constructorToResolve.GetParameters();
            if (constructorParameters.Length == 0)
            {
                return Activator.CreateInstance(resolvedType);
            }

            IList<object> parameters = new List<object>();
            foreach (var parametersToResolve in constructorParameters)
            {
                parameters.Add(Resolve(parametersToResolve.ParameterType));
            }
            return constructorToResolve.Invoke(parameters.ToArray());

        }

        public void Register<TFrom, TTo>()
        {
            //validate if (TTo impl TFrom)
            if (typeof(TFrom).GetInterfaces().Contains(typeof(TTo)))
            {
                dependencyMap.Add(typeof(TFrom),typeof(TTo));
                Console.WriteLine("Valid");
            }
            Console.WriteLine("Invalid");
        }
    }

    public sealed class Sing:IInjection
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>();

        public static Singleton Instance => lazy.Value;
        private Sing()
        {
        }

        public void Injection()
        {
            
        }
    }

    public interface IInjection
    {
        void Injection();
    }
}