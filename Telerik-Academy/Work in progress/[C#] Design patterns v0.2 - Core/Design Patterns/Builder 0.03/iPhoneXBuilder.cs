using System;

namespace Builder_0._03
{
    public class iPhoneXBuilder:MobilePhoneBuilder
    {
        public override void InstallOS()
        {
            phone.OsType = OS.ios;

            Console.WriteLine($"-> logging ios was installed on {this.GetType().Name}");
        }

        public override void AddSensors()
        {
            phone.Sensors.Add("gyro");
            phone.Sensors.Add("GPS");

            Console.WriteLine("-> added gyro and GPS sensors");
        }
    }
}