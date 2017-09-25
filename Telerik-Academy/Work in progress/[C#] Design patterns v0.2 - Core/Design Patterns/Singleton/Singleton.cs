using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(true);
        public static Singleton Lazy => lazy.Value;

        private Singleton(){}
    }

    public class S
    {
        public Singleton FSingleton = Singleton.Lazy;
    }
}