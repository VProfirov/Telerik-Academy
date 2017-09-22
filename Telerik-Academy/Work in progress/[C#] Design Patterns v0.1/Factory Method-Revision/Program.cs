using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Revision
{
    using System.Security.Policy;
    using System.Text.RegularExpressions;

    using Factory_Method_Revision.Concrete_Creator;
    using Factory_Method_Revision.Creator;

    class Program
    {
        static void Main(string[] args)
        {
            var publsiher = new Colibri_Publisher() as IPublisher;
            var docsToPrint = publsiher.GetPublicationOnSubject("Biology ").GetPublicationDocuments();
            

            foreach (var doc in docsToPrint)
            {
                Console.WriteLine(doc.Title);
            }

        }
    }
}
