using System;
using System.Collections.Generic;
using System.Linq;

namespace IoCContainer_Demo_.Practices
{
    public class ResolverV03
    {
        private Dictionary<Type,Type> defaultDependencyMap = new Dictionary<Type,Type>();
        private Type resolvedType = null;
        private Dictionary<string,Type> alternativesDependencyMap = new Dictionary<string,Type>();

        public T Resolve<T>()
        {
            return (T) Resolve(typeof(T));
        }

        private object Resolve(Type typeToResolve)
        {
            try
            {
                resolvedType = defaultDependencyMap[typeToResolve];
                if (alternativesDependencyMap.ContainsKey(typeToResolve.Name))
                {
                    Alternate();
                }
            }
            catch
            {
                throw new ArgumentException($"Resolving problem of type {typeToResolve}");
            }
            var constructorToResolve = resolvedType.GetConstructors().First();
            var parametersToResolve = constructorToResolve.GetParameters();
            if (parametersToResolve.Length == 0)
            {
                return Activator.CreateInstance(resolvedType);
            }

            IList<object> resolvedParameters = new List<object>();
            foreach (var parameterInfo in parametersToResolve)
            {
                resolvedParameters.Add(Resolve(parameterInfo.ParameterType));
            }

            return constructorToResolve.Invoke(resolvedParameters.ToArray());
        }

        //smart? RegisterInjection
        public void RegisterInjection<TFrom,TTo>()
        {
            if (defaultDependencyMap.ContainsKey(typeof(TFrom)))
            {
                alternativesDependencyMap.Add(typeof(TFrom).Name, typeof(TTo));
            }
            else
            {
                defaultDependencyMap.Add(typeof(TFrom), typeof(TTo));
            }
        }

        public void RegisterType<T>()
        {
            try
            {
                defaultDependencyMap.Add(typeof(T), typeof(T));
            }
            catch 
            {
                throw new ArgumentException("The registered type to be resolved already exists");
            }

        }

        private void Alternate()
        {
            Console.WriteLine("Currently you are using the default(first registered) injection that can be used to resolve");
            Console.WriteLine("Do you want to swap it? (Y/N)");
//            var answer = Console.ReadLine();
            var answer = "y";

            if (answer.ToLower() == "y")
            {
                try
                {
                    Swapper();
                }
                catch
                {
                    Console.WriteLine("Wrong input try again");
                    Swapper();
                }

                void Swapper()
                {
                    Console.WriteLine($"Swapping {resolvedType.Name} for:");
                    foreach (var alternative in alternativesDependencyMap)
                    {
                        Console.WriteLine(alternative.Value.Name);
                    }

                    Console.Write("Chose one: ");

                    #region ProblematicArea
                    //TFrom problem
                    var swap = Console.ReadLine();
                    var typeToSwap = Type.GetType(" IoCContainer_Demo_." + swap);
                    var temp = alternativesDependencyMap[swap];

                    alternativesDependencyMap[swap] = defaultDependencyMap[typeToSwap];
                    defaultDependencyMap[typeToSwap] = temp;
                    #endregion
                }
            }
        }
    }
}