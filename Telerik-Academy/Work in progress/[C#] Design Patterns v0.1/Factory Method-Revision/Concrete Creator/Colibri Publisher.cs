using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Revision.Concrete_Creator
{
    using System.Diagnostics;

    using Factory_Method_Revision.Concrete_Product;
    using Factory_Method_Revision.Creator;
    using Factory_Method_Revision.Product;

    class Colibri_Publisher:IPublisher
    {
        public Publication GetPublicationOnSubject(string publicationField)
        {
            if (publicationField.ToLower().Contains("biology"))
            {
                return new Biology_Publication();
            }
            else if (publicationField.ToLower().Contains("physics"))
            {
                return new Physics_Publication();
            }
            else
            {
                throw new ArgumentException($"There is no support for {publicationField}  publications");
            }
            
        }
    }
}
