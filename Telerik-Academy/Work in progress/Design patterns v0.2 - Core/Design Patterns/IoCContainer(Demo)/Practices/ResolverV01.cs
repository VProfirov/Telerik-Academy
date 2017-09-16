using System;
using System.Collections.Generic;
using System.Linq;

namespace IoCContainer_Demo_.Practices
{
    public class ResolverV01
    {
        private Dictionary<Type,Type> dependencyMap = new Dictionary<Type, Type>();

        public T Resolve<T>()
        {
            return (T) Resolve(typeof(T));
        }

        private object Resolve(Type typeToReslove)
        {
            Type resolvedType = null;
            try
            {
                resolvedType = dependencyMap[typeToReslove];
            }
            catch
            {
                throw new ArgumentException($"Error when resolving the type {typeToReslove}");
            }

            var firstConstructor = resolvedType.GetConstructors().First();
            var constructorParameters = firstConstructor.GetParameters();

            if (constructorParameters.Length == 0)
            {
                return Activator.CreateInstance(resolvedType);
            }

            IList<object> parameters = new List<object>();
            foreach (var constructorParameter in constructorParameters)
            {
                parameters.Add(Resolve(constructorParameter.ParameterType));    
            }

            return firstConstructor.Invoke(parameters.ToArray());
        }

        public void Register<TFrom, TTo>()
        {
            dependencyMap.Add(typeof(TFrom),typeof(TTo));
        }
    }
}