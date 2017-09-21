using System;

namespace InheritanceFileds
{
    using static Ext;
    class Program
    {
        static void Main(string[] args)
        {
            var b = new B();
            b.Print(b.shared);
            b.Print(b.b);
            b.b = "changed BB";
            Console.WriteLine(b.b + "<== change B");
            b = new C();
            b.Print((b as C).c);
            b.Print((b as C).b);
        }
        
    }

    public static class Ext
    {
        public static void Print(this object o,string str)
        {
            Console.WriteLine(str);
        }
    }
}
