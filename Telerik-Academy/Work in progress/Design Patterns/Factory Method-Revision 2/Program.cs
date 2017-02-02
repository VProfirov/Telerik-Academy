using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Revision_2
{
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
           Document[] documents = new Document[2];
            documents[0] = new EducationalDocument();
            documents[1] = new MagazineDocument();

            foreach (var document in documents)
            {
                Console.WriteLine("\n" + "--"  + document.GetType().Name + "--");
                foreach (var documentPage in document.Pages)
                {
                    Console.WriteLine("  " + documentPage.GetType().Name);
                }
            }
        }
    }

    //Product
     abstract class Page
    {
    }
    //Concrete Product
    class EducationalPage : Page
    {
    }

    class MagazinePage : Page
    {
    }

    //Creator
     abstract class Document
     {
//         private  readonly List<Page> _pages = new List<Page>();
/// <summary>
/// readonly list : no interaction, rather then reading, can be associated with the list
/// </summary>
        public Document()
        {
            this.CreatePages();
        }

//         public List<Page> Pages => this._pages;
         public List<Page> Pages { get; } = new List<Page>();

         public abstract void CreatePages();
    }
    //Concrete Creator
    class EducationalDocument:Document
    {
        public override void CreatePages()
        {
            Pages.Add(new EducationalPage());
            Pages.Add(new EducationalPage());
            Pages.Add(new EducationalPage());
        }
    }
    class MagazineDocument:Document
    {
        public override void CreatePages()
        {
            Pages.Add(new MagazinePage());
        }
    }
}
