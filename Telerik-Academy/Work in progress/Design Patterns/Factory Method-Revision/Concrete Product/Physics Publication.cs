using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Revision.Concrete_Product
{
    using Factory_Method_Revision.Product;
    using Factory_Method_Revision.Product.Util;

    class Physics_Publication:Publication
    {
        public override IList<Document> GetPublicationDocuments()
        {
            // subjects implementation ... Gravity; Blackholes;...
            Documents.Add(new Document() {Title = "Resume of physics publication"});
            Documents.Add(new Document() {Title = "Main Publication: \"Gravity is not real\""});
            return Documents;
        }
    }
}
