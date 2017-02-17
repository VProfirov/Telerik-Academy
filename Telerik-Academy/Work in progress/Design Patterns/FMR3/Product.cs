using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMR3
{
    class Product:IProduct
    {

        public Product()
        {
            
        }
        public Product(int age)
        {
            this.Age = age;
        }
        public string Name { get; }
        public int Age { get; set; }
        public void Speak()
        {
            Console.WriteLine("hi");
        }
    }
}
