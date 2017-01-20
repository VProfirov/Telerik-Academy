using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.Factory
{
    using Telenor.Factory.Functionality;
    using Telenor.Factory.Utils;
    using Telenor.UnitTests;

    class GSM
    {
        //explicit props
        public static GSM iPhone4s { get;} = new GSM("iPhone4S", "Apple");

        public List<Call> CallHistory { get; set; }

        //ctors
        public GSM(string model, string manufacturer)
        {
                
        }
        //methods
        public override string ToString()
        {
            return base.ToString();
        }

        public void AddCall()
        {
            
        }

        public void DeleteCall()
        {

        }

        public decimal CallPrice()
        {
            throw new NotImplementedException("calculates the total price of the calls in the call history.");
        }
    }
}
