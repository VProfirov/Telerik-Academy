using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Revision.Concrete_Product
{
    using Factory_Method_Revision.Product;
    using Factory_Method_Revision.Product.Util;

    class Biology_Publication:Publication
    {
        public override IList<Document> GetPublicationDocuments()
        {
            Documents.Add(new Document() {Title = "Resume of birds publication"});
            Documents.Add(new Document() {Title = "Main Publication : \"Birds nesting rituals\""});
            return Documents;
        }
    }
}
