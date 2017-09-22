using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Revision.Creator
{
    using Factory_Method_Revision.Product;
    interface IPublisher
    {
        Publication GetPublicationOnSubject(string publicationField);
    }
}
