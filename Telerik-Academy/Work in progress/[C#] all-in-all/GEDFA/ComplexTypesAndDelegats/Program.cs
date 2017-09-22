using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTypesAndDelegats
{
    using System.Reflection;

    class Program
    {
        public delegate string Changer();

        public delegate string Cunt(int lvl, string idiotism);

        public delegate void FU();

        static void Main(string[] args)
        {
            Car newCar = new Car("troshka","BWM");


            Changer change = new Changer(newCar.iModel);
            change();

            Program pr = new Program();
            Cunt cunt = new Cunt(pr.WTF);
            cunt += pr.WTF;
            var c = cunt.GetMethodInfo().ToString();

            Console.WriteLine(c);
            cunt.Invoke(5, "normal");


            Cunt cunt2 = pr.WTF;
            cunt2(10,"mtf");

            FU fuCar = newCar.ModelChange;
//            fuCar.Invoke(); //== fuCar();
            fuCar();

            Console.WriteLine(newCar.iModel());
        }


        string WTF(int lvl,string idio)
        {
            Console.WriteLine($"Level {lvl} of idiotism:{idio}");
            return "fu return";
        }


    }

}
