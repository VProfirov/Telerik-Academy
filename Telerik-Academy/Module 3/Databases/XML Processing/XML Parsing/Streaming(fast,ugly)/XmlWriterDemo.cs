using System.Collections.Generic;
using System.Xml;
using XML_Parsing.Classes;
namespace XML
{
    public class XmlWriterDemo
    {
        public static void Demo()
        {
            var books = new List<Book>
            {
                new Book()
                {
                    Id = 1,
                    Title = "The fn Ring",
                    Author = "FFF Tolkein"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Walking Dead",
                    Author = "The Dead Author"
                },
                new Book()
                {
                    Id = 3,
                    Title = "The Ring",
                    Author = "The Bitch from the screen"
                }, new Book()
                {
                    Id = 6666,
                    Title = "5",
                    Author = "5"
                }
            };
            using (var writer = XmlWriter.Create("../books.xml"))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("books");
                foreach (var book in books)
                {
                    WriteNextBook(writer, book);
                }
                writer.WriteEndElement();

                writer.WriteEndDocument();
            }
            
        }

        private static void WriteNextBook(XmlWriter writer, Book book)
        {
            writer.WriteStartElement("book");
            writer.WriteAttributeString("id", book.Id.ToString());

            //            writer.WriteStartElement("title"); <= for complex hierarchy 
            writer.WriteElementString("title", book.Title);
            writer.WriteElementString("author", book.Author);

            writer.WriteEndElement();
        }
    }
}