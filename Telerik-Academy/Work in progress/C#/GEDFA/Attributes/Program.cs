using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        var assembly = Assembly.GetEntryAssembly();
        Console.WriteLine(assembly.FullName);

        var types = assembly.GetTypes();
        foreach (var type in types)
        {
            Console.WriteLine("Type: " + type);
            Console.WriteLine();
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                Console.WriteLine($"\tProperties: {prop}");
            }

            var fields = type.GetFields();
            foreach (var field in fields)
            {
                Console.WriteLine($"\t\tFields: {field}");
            }

            var methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine($"\t\t\tMehods: {method}");
            }
        }
    }

    public class SampleClass
    {
        public string someField;
        public int MyProperty { get; private set; }

        public void MyMethod() { }
    }
}