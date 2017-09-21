using System;

namespace MethodsAndScopes
{
    class Program
    {
        public string str = "hi";
        static void Main(string[] args)
        {
            var st = "args";
            var s = "args";


        }

        public void StrCall(string s /*, string str : conflict of same var name declaration in a scope */)
        {
            var str = s; //hides the field (IntelliSense  marks it)
            Console.WriteLine(str);
        }
    }

    public class SomeClass
    {
        public void M() => Console.WriteLine("public void M()");
            
        // different method different signature
        public virtual void M(string str) => Console.WriteLine("public virtual void M(string str)");

        //        public override void M(int i) => //error no method to override (no inher)
    }
}
