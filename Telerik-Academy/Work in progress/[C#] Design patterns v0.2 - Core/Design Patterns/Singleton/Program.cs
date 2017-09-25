using System;
using System.ComponentModel;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Singleton
    {
        private static Singleton _instance;
        private Singleton()
        {
            
        }

        //Not Thread Safe - don't use for web
        public static Singleton Instance => _instance ?? (_instance = new Singleton());
    }

    public class LazySingleton
    {
        private LazySingleton()
        {
        }

        // IS Thread Safe
        public static LazySingleton Instance => Nested.instance;

        private class Nested
        {
            internal static readonly LazySingleton instance = new LazySingleton();
            static Nested()
            {
            }
        }
    }
}
