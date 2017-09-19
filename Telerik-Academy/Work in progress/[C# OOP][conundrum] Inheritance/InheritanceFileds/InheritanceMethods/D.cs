using System;

namespace InheritanceMethods
{
    public class D:C
    {
        public string controlFieldD = "class d Control";

        public new void Change(string d)
        {
            str = "Changed in DDdd";
            num = 22222;

            Console.WriteLine(str);
            Console.WriteLine(num);
        }
    }
}