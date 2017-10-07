using System;
using System.Collections.Generic;
using System.Reflection;

namespace Factory_Pattern
{
    public class AutoFactory
    {
        private Dictionary<string, Type> autos;

        public AutoFactory()
        {
            LoadReturnTypes();
        }

        public IAuto CreateInstance(string carName)
        {
            var t = GetTypeToCreate(carName.ToLower());
            if (t == null)
                return new NullAuto();
            return Activator.CreateInstance(t) as IAuto;
        }

        private Type GetTypeToCreate(string carName)
        {
            foreach (var auto in autos)
                if (auto.Key.Contains(carName))
                    return autos[auto.Key];
            return null;
        }

        private void LoadReturnTypes()
        {
            autos = new Dictionary<string, Type>();

            Type[] assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var t in assemblyTypes)
            {
                if (t.GetInterface(typeof(IAuto).Name) != null)
                {
                    autos.Add(t.Name.ToLower(),t);
                }
            }
        }
    }
}