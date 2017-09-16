using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Builder_0._03
{
    public class MobilePhone
    {
        public IList<string> Sensors { get; set; } = new List<string>();
        public OS OsType { get; set; }

        public void Display()
        {
            Console.WriteLine($"Mobile with {OsType} OS");
            Console.WriteLine("and has these sensors:");
            foreach (var sensor in Sensors)
            {
                Console.WriteLine(sensor);
            }
        }
    }

    public enum OS
    {
        android,ios,windows
    }
}