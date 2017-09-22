using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonAndStaticConstructors
{
    using System.Reflection;
    using System.Runtime.CompilerServices;

    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Level1
    {
        private static string staticString;

        private string nonString;

        private readonly string readonlyString;

        private static readonly string staticReadonlyString;
        static Level1()
        {
            // [!important]
            // Methods, *instance* constructors, indexers, and operators are characterized by their signatures
            staticString = "static string";
            staticReadonlyString = "staticReadonlyString";

            ///https://msdn.microsoft.com/en-us/library/79b3xss3.aspx
        }
        public Level1()
        {
            Console.WriteLine("Level 1");

            // can access all fields
        }

        public Level1(string addon)
        {
            Console.WriteLine($"Level 1 - {addon}");

        }
    }

    class Level2 : Level1
    {
        public Level2()
        {
            Console.WriteLine("Level 2");
        }

        public Level2(string addon)
        {
            Console.WriteLine($"Level 2 - {addon}");

        }
    }

    class Level3 : Level2
    {
        public Level3()
        {
            Console.WriteLine("Level 3");
        }

        public Level3(string addon)
        {
            Console.WriteLine($"Level 3 - {addon}");

        }
    }
}
