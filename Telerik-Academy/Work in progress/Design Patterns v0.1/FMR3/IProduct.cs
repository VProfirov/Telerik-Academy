using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMR3
{
    interface IProduct
    {
        string Name { get; }
        int Age { get; set; }

        void Speak();
    }
}
