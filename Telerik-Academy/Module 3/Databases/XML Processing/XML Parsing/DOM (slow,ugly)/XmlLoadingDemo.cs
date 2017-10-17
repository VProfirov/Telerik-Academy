using System;
using System.IO;
using System.Xml;

namespace XML
{
    public class XmlLoadingDemo
    {
        static string GetXml()
        {
//            TextReader reader = File.OpenText(@"..\catalog.xml");
            TextReader reader = File.OpenText("../catalog.xml");
            return reader.ReadToEnd();
        }

        public static void Demo()
        {
            var xml = GetXml();
            var doc = new XmlDocument();
            //            doc.LoadXml(xml);
            doc.Load(File.OpenRead(@"..\catalog.xml"));
            var root = doc.DocumentElement;
            //            Console.WriteLine(root.Name);

            PrintChild(root, "");
        }

        static void PrintChild(XmlNode node, string indent)
        {
            var attrs = string.Empty;
            if (node.Attributes != null)
            {
                // NotWorking
                //                foreach (XmlElement attr in node)
                //                foreach (XmlText attr in node
                
                foreach (XmlNode attr in node)
                {
                    Console.WriteLine(attr.ToString()); // inner heirchy
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