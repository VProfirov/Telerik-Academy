using System;

namespace Singleton
{
    public class SingletonsNewAndOld
    {
        
    }
    public class SingletonOld
    {
        private static volatile SingletonOld instance;
        private static object syncRoot = new Object();

        private static SingletonOld _instance;
        private SingletonOld()
        {

        }

        //Not Thread Safe - don't use for web
        public static SingletonOld Instance => _instance ?? (_instance = new SingletonOld());

        //Oldschool "Double Checked Locking" Trade Safe, BUT using only Single Thread
        public static SingletonOld Instance2
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SingletonOld();
                    }
                }

                return instance;
            }
        }
    }

    // Lazy SingletonOld => INSTEAD of using locking --> public static SingletonOld Instance => instance?? (lock(syncRoot){instance?? new SingletonOld()});
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

    //LAZY SingletonOld => clr reasons
    public class LazySingletonAlternative
    {
        //can't be explicitly private - but it is private
        static LazySingletonAlternative()
        {
        }

        //can't be explicitly *readonly*
        //can't use *private static constructor* here - because it is static
        internal static LazySingleton Instance { get; set; } /* => new LazySingleton();*/
    }

    // New Lazy => .Net 4 and up, C#6 and up
    public sealed class NewLazySingleton
    {
        private static readonly Lazy<NewLazySingleton> lazy = new Lazy<NewLazySingleton>();
        private NewLazySingleton() { }

        public static NewLazySingleton Instance => lazy.Value;
    }
}