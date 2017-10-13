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
            var xml = GetXml();
            var doc = new XmlDocument();
//            doc.LoadXml(xml);
            doc.Load(File.OpenRead(@"..\catalog.xml"));
            var root = doc.DocumentElement;
//            Console.WriteLine(root.Name);
            
            PrintChild(root,"");
        }

        static void PrintChild(XmlNode node,string indent)
        {
            var attrs = string.Empty;
            if (node.Attributes != null)
            {
                foreach (XmlElement attr in node)
                {
                    attrs += attr.Name + ": " + attr.Value + ", ";
                }
            }
            
            Console.WriteLine(indent + node.Name + "(" + attrs + ")");
            foreach (XmlNode child in node)
            {
                PrintChild(child, indent + "--");
            }
        }
    }
}
