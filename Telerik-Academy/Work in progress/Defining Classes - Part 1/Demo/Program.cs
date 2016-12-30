using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var someF = "Red";
            var f = (Feathers) Enum.Parse(typeof(Feathers), someF, true);
            Console.WriteLine(f);

            Console.WriteLine("______следва ХАКЕРИЯ_______");
            GSM_Demo wtfGSM = new GSM_Demo();
            Console.WriteLine(GSM_Demo.SomsSTATICstring);
            Console.WriteLine(wtfGSM.AssPROP);
            Console.WriteLine(wtfGSM.AssPROP = "ass set");
            Console.WriteLine(GSM_Demo.SomsSTATICstring);
            Console.WriteLine(GSM_Demo.AssStaticPROP);
            Console.WriteLine(GSM_Demo.SomsSTATICstring);
        }

        enum Feathers { Red, Green }
    }
}
