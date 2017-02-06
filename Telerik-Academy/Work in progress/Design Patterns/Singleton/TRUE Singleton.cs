namespace Singleton
{
    class TRUE_Singleton
    {
        /// <summary>
        /// Singleton is described as an anti pattern (don't use if possible)
        /// Suitable if more advance situation of instantiation is required [rare cases]
        /// </summary>
        /// https://msdn.microsoft.com/en-us/library/ms998558.aspx
        /// *Singleton
        /// *Static Initialization - lazy evaluation |/ some tradeoffs
        /// *Multithreaded Singleton
        public class Singleton
        {
            private static Singleton instance;

            private Singleton()
            {
            }

            public static Singleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }

                    return instance;
                }
            }
        }

        /// <summary>
        /// Multi Thread Safe using Double Lock idiom
        /// </summary>
        public sealed class Singleton_MultithreadSafe
        {
            private static Singleton_MultithreadSafe _instance;

            private static object syncRoot = new object();

            private Singleton_MultithreadSafe()
            {
            }

            public static Singleton_MultithreadSafe Instance
            {
                get
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                        {
                            return _instance = new Singleton_MultithreadSafe();
                        }
                        return _instance;
                    }
                }
            }
        }

        /// <summary>
        /// USE THIS in most of the cases as the more flexible version of thread safe singleton
        /// </summary>
        public sealed class Singleton_With_StaticInstantiation
        {
            private static readonly Singleton_With_StaticInstantiation _instance =
                new Singleton_With_StaticInstantiation();

            private Singleton_With_StaticInstantiation()
            {

            }

            public static Singleton_With_StaticInstantiation Type => _instance;

            public void DoSomeSinglePurpseActionMethod()
            {
            }
        }

        /// The instantiation is not performed until an object asks for an instance; this approach is referred to as lazy instantiation. Lazy instantiation avoids instantiating unnecessary singletons when the application starts.
        /// Sub Difference : can use subclasses

        /// MAIN DIFFERENCE between Singleton and Static Class : LAZY INSTANTIATION

        /// http://www.c-sharpcorner.com/UploadFile/akkiraju/singleton-vs-static-classes/
    }
}