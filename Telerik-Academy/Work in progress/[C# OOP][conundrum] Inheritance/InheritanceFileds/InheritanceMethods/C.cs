using System;

namespace InheritanceMethods
{
    public class C:B
    {
        public string controlFieldC = "class C Control";
        
        public new void Change(string c)
        {
            str = "Changed in CCC";
            num = 10101;

            Console.WriteLine(str);
            Console.WriteLine(num);
        }

        public void Special()
        {
            Console.WriteLine(controlFieldC + "C");
        }
    }
}