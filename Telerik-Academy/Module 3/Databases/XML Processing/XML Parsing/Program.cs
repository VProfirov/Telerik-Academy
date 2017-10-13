using System;
using System.IO;
using System.Xml;

namespace XML_Parsing
{
    class Program
    {
        static string GetXml()
        {
            TextReader reader = File.OpenText(@"..\catalog.xml");
            return reader.ReadToEnd();
        }

        static void Main()
        {
            var doc = new XmlDocument();
        }
    }
}
