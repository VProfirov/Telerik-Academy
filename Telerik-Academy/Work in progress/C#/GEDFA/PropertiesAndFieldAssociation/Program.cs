using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndFieldAssociation
{
    class Program
    {
        private int iset;
        static void Main(string[] args)
        {
        }

        public int IntGetSet { get; set; }
        public int IntGet { get;}
        //        public int IntSet { set; } // AutoProp must have a get{defined}

        public int IntSet {
            set
            {
                this.iset = value;
            }
        }

        // readonly...
    }
}
