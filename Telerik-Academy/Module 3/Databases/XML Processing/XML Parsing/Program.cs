using System;
using System.IO;
using System.Xml;

namespace XML_Parsing
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var reader = XmlReader.Create("../catalog.xml"))
            {
                while (reader.Read())
                {
                    reader.Read();
                    if (reader.IsStartElement() && reader.Name == "title")
                    {
                        reader.Read();
                        Console.WriteLine(reader.Value);
                    }
                }
            }
        }
    }
}