using System;

namespace Builder_0._03
{
    class Program
    {
        static void Main(string[] args)
        {
            //            var phoneMaker = new MobilePhoneMaker(new iPhoneXBuilder());
            var phoneMaker = new MobilePhoneMaker(new SamsungGalaxy8Builder());

            phoneMaker.BuildMobilePhone();
            var phone = phoneMaker.GetMobilePhone();
            phone.Display();
        }
    }
}
