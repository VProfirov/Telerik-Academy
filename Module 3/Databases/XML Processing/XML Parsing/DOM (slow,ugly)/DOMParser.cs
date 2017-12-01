using System;
using System.Xml;

namespace XML_Parsing
{
    public class DOMParser
    {
        public static void Demo()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../library.xml");
//            doc.Load("../catalog.xml");
            Console.WriteLine("Loaded XML document:");
            Console.WriteLine(doc.OuterXml);
            Console.WriteLine();

            XmlNode rootNode = doc.DocumentElement;
            Console.WriteLine("Root node: {0}", rootNode.Name);

            foreach (XmlAttribute atr in rootNode.Attributes)
            {
                Console.WriteLine("Attribute: {0}={1}",
                    atr.Name, atr.Value);
            }
            Console.WriteLine();
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                Console.WriteLine("Book title = {0}",
                    node["title"].InnerXml);//InnerText
                Console.WriteLine("Book author = {0}",
                    node["author"].OuterXml);//InnerText
                Console.WriteLine("Book isbn = {0}",
                    node["isbn"].InnerText);
                Console.WriteLine();
            }
        }
    }
    
}