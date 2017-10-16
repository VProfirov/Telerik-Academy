using System;
using System.Collections;
using System.Collections.Generic;

namespace XML_Parsing.Classes
{
    public class Album
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public string Producer { get; set; }
        public decimal Price { get; set; }
//        public IList<string> Songs { get; set; }
        public override string ToString()
        {
            return $@"---Album---
ID: {ID}
Name: {Name}
Artist: {Artist}
Year: {Year}
Producer: {Producer}
Price: {Price}
-----------";
        }
    }
}