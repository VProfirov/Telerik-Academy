using System;

namespace InheritanceMethods
{
    public class B:A
    {
        public string controlFieldB = "class B Control";
        public void Change(string b)
        {
            str = "CHanged in B";
            num = 5;


            Console.WriteLine(str);
            Console.WriteLine(num);
        }
    }
}