using System;
using System.Xml;
using XML_Parsing.Classes;

namespace XML
{
    public class XmlReaderDemo
    {
        public static void Demo()
        {
            using (var node = XmlReader.Create("../catalog.xml"))
            {
                Album album = ReadNextAlbum(node);
                while (album != null)
                {
                    Console.WriteLine(album);
                    album = ReadNextAlbum(node);
                }
            }
        }

        private static Album ReadNextAlbum(XmlReader node)
        {
            var album = new Album();
            var isIdRead = false;
            var isNameRead = false;
            var isArtistRead = false;
            var isYearRead = false;
            var isProducerRead = false;
            var isPriceRead = false;

                while ((!isIdRead || !isNameRead||!isArtistRead||!isYearRead||!isProducerRead||!isPriceRead) && node.Read())
                {
                    if (node.IsStartElement() && node.Name == "album")
                    {
                        album.ID = int.Parse(node.GetAttribute("id"));
                        isIdRead = true;
                    }
                    if (node.IsStartElement() && node.Name == "name")
                    {
                        node.Read();
                        album.Name = node.Value;
                        isNameRead = true;
                    }
                    if (node.IsStartElement() && node.Name == "artist")
                    {
                        node.Read();
                        album.Artist = node.Value;
                        isArtistRead = true;
                    }
                    if (node.IsStartElement() && node.Name == "year")
                    {
                        node.Read();
                        album.Year = int.Parse(node.Value);
                        isYearRead = true;
                    }
                    if (node.IsStartElement() && node.Name == "producer")
                    {
                        node.Read();
                        album.Producer = node.Value;
                        isProducerRead = true;
                    }
                    if (node.IsStartElement() && node.Name == "price")
                    {
                        node.Read();
                        album.Price = decimal.Parse(node.Value);
                        isPriceRead = true;
                    }
                }
                if (isIdRead == false || isNameRead == false || isArtistRead == false ||isYearRead == false ||isProducerRead == false||isPriceRead == false )
                {
                    return null;
                }
                //TODO: NB! expand the example
            
            return album;
        }
    }
}