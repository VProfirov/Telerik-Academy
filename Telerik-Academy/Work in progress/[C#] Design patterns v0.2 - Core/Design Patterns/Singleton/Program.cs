using System;
using System.Security.Cryptography.X509Certificates;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var iocSingleton = new SingleonIoC();
            iocSingleton.Register<IInjection, Sing>();
        }
    }
}
