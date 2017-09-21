using System;
using System.Runtime.InteropServices;

namespace InheritanceMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //method signature hiding ; virtual ; override : in deep inheritance

            BaseClass b = new DerivedClass();

            b.M();
            //bc-dc:=> BC-M : virt/virt/over
            //bc-dc:=> BC-M : virt/ new virt /over
            //bc-dc:=> BC-M : _/ new virt /over

            //Sc-dc:=> DC-M : _/virt/over
            //Sc-dc:=> DC-M : virt/virt/over

            // XX <=:=>      virt/ new|_ /over
        }
    }

    public class BaseClass
    {
        public virtual void M() => Console.WriteLine("BaseClass-Method");
    }

    public class SubClass:BaseClass
    {
        public  new virtual void M() => Console.WriteLine("SubClass-Method");
    }
    public class DerivedClass:SubClass
    {
        public override void M() => Console.WriteLine("DerivedClass-Method");
    }
}
