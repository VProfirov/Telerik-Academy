using System;
using System.Collections.Generic;
using System.Linq;

namespace IoCContainer_Demo_.Practices
{
    public class Resolverv02
    {
        private Dictionary<Type,Type> dependencyMap = new Dictionary<Type, Type>();
        public T Resolver<T>()
        {
            return (T)Resolve(typeof(T));
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

            var constructorToResolve = typeToResolve.GetConstructors().First();
            var constructorParameters= constructorToResolve.GetParameters();
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
            dependencyMap.Add(typeof(TFrom), typeof(TTo));
        }
    }
}