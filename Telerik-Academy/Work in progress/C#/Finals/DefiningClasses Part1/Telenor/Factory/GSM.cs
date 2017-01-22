using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.Factory
{
    using System.Text.RegularExpressions;

    using Telenor.Factory.Functionality;
    using Telenor.Factory.Utils;
    using Telenor.UnitTests;

    class GSM
    {
        //explicit props
        public static GSM iPhone4s { get; } = new GSM("iPhone4S", "Apple");

        public List<Call> CallHistory { get; set; } = new List<Call>();

        //ctors
        public GSM(string model, string manufacturer)
        {

        }
        
        public GSM(string model,string manufacturer,decimal price,string owner,Battery battery, Display display):this(model, manufacturer)
        {
            
        }
        //methods
        public override string ToString()
        {
            return base.ToString();
        }

        public void AddCall(string oppositeNumber)
        {
            Call nextCall = new Call(oppositeNumber);
            CallHistory.Add(nextCall);
        }

        public void DeleteCall(object target)
        {
            try
            {
                ////remove by [position; phone number]
                if ((target is int) && ((int)target <= CallHistory.Count && (int)target > 0))
                {
                    CallHistory.RemoveAt((int)target);
                }
                else if ((target is string) && 
                    Regex.Match((string)target, @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$")
                         .Success)
                {
                    for (int i = 0; i < CallHistory.Count; i++)
                    {
                        if (CallHistory[i].PhoneNumber == (string)target)
                        {
                            CallHistory.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                
                throw new ArgumentException("The target is neither call at position, neither a phone number\r\n",e);
            }
           
        }
        
        public decimal CallPrice()
        {
            throw new NotImplementedException("calculates the total price of the calls in the call history.");
        }
    }
}
