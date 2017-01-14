using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Level3 lvl = new Level3("addon at 3");
        }
    }


    class Level1
    {
        public Level1()
        {
            Console.WriteLine("Level 1");
        }

        public Level1(string addon)
        {
            Console.WriteLine($"Level 1 - {addon}");

        }
    }

    class Level2:Level1
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

    class Level3:Level2
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
///https://msdn.microsoft.com/en-us/library/ms229027.aspx
/// 
/// 
/// Base class constructor is needed to be defined down the chain, if any constructor in the heirarchy is