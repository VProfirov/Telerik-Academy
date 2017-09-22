using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    class Cat:IAnimal
    {
        public string Name { get; set; }
        public void Jump()
        {
            Console.WriteLine("Jumping Cat!");
        }
    }
}
