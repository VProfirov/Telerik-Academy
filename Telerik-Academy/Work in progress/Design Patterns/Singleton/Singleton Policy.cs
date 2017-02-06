using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton_Policy
    {
        private int ID { get; set; } = 123;

        private string Insured { get; set; } = "John Doe";

        public string GetInsured() => Insured;
    }
}
