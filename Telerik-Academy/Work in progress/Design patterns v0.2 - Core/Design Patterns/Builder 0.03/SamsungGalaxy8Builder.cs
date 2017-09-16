using System;

namespace Builder_0._03
{
    public class Samsung_Galaxy_8:MobilePhoneBuilder
    {
        public override void InstallOS()
        {
            phone.OsType = OS.android;

            Console.WriteLine($"-> logging android was installed on {this.GetType().Name}");
        }

        public override void AddSensors()
        {
            phone.Sensors.Add("teleportation");

            Console.WriteLine("-> added teleportation sensor");
        }
    }
}