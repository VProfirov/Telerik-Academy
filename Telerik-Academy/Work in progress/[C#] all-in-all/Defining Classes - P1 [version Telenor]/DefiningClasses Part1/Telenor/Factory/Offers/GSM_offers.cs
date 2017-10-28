using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.Factory.Offers
{

    abstract class GSM_Offers
    {
        public static void ShowSpecialOffers()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}*Special Clients Offer*{0} \r\n", new string(' ', 5));
            sb.AppendLine($@"We offer a brand new {GSM.iPhone4s.Model} from {GSM.iPhone4s.Manufacturer}"); // calling the iPhone Stack overflow
            sb.AppendLine("to commemorate our loyal customers");
            sb.AppendLine("****************************************");

            var message = sb.ToString();

            Console.WriteLine(message);
        }
    }
}
