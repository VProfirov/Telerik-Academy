using System;

namespace Builder_0._01
{
    class Program
    {
        static void Main(string[] args)
        {
            var shampooMaker = new ShampooMaker(new DoveMenBuilder());
            shampooMaker.BuildShampoo();
            var doveMen = shampooMaker.GetShampoo();
            doveMen.DisplayProduct();
        }
    }
}
