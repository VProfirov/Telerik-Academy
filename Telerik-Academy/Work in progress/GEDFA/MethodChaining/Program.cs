namespace MethodChaining
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            SimpleClass s = new SimpleClass();
            var result = s.Age10().MyInfo(5);

            Console.WriteLine(result.ToString());
        }
    }
}