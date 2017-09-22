using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    interface IAnimal
    {
        string Name { get; set; }
        void Jump();
    }
}
