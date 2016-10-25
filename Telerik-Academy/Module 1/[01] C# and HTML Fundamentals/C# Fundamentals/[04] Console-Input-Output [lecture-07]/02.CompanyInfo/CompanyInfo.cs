/*Problem 2.	Print Company Information
A company has name, address, phone number, fax number, web site and manager.
The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
* Example:
 
  program	        user
Company name:	    Software University
Company address:	26 V. Kanchev, Sofia
Phone number:	    +359 899 55 55 92
Fax number:	
Web site:	        http://softuni.bg
Manager first name:	Svetlin
Manager last name:	Nakov
Manager age:	    25
Manager phone:	    +359 2 981 981
 * 
 * PrintOut :
 Software University
Address: 26 V. Kanchev, Sofia
Tel. +359 899 55 55 92
Fax: (no fax)
Web site: http://softuni.bg
Manager: Svetlin Nakov (age: 25, tel. +359 2 981 981)
 * 
 */

namespace CompanyInfo
{
    using System;

    class CompanyInfo
    {
        static void Main()
        {
            Console.WriteLine("This program collects corporate information.");
            Console.WriteLine();

            //Company's name, address, phone number, fax number, web site.

            Console.Write("Please input the Company's name : ");
            string companyName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please input the Company's address : ");
            string address = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please input the Company's phone number : ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please input the Company's fax number : ");
            string faxNumber = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please input the Company's web site : ");
            string webSite = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Thank you.");
            Console.WriteLine();

            //Company's manager first name, last name, age and a phone number.
            Console.WriteLine("Now please input the manager's personal information.");
            Console.WriteLine();

            Console.Write("Please input the manager's first name : ");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please input the manager's last name : ");
            string managerLastName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please input the manager's age : ");
            string age = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please input the manager's phone number : ");
            string managerPhoneNumber = Console.ReadLine();
            Console.WriteLine();

            // Output of the total collected information
            Console.WriteLine("List of the collected information : ");
            Console.WriteLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Phone number: {0}", phoneNumber);
            Console.WriteLine("Fax number: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.Write("Manager : {0} ", managerFirstName);
            Console.Write(" {0}", managerLastName);
            Console.Write(" (age: {0},", age);
            Console.Write(" tel. : {0})", managerPhoneNumber);
            Console.WriteLine();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("The company name is: {0}", companyName);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Phone number: {0}", phoneNumber);
            Console.WriteLine("Fax number: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager first name: {0}", managerFirstName);
            Console.WriteLine("manager last name: {0}", managerLastName);
            Console.WriteLine("Manager age: {0}", age);
            Console.WriteLine("Manager Phone Number: {0}", managerPhoneNumber);
            Console.WriteLine("----------------------------------------");
        }
    }
}
