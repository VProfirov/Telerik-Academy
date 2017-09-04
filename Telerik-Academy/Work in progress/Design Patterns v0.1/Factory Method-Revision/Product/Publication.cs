using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Revision.Product
{
    using Factory_Method_Revision.Product.Util;
    internal abstract class Publication
    {
        public IList<Document> Documents { get; private set; } = new List<Document>();

        public abstract IList<Document> GetPublicationDocuments();
        
    }
}
