using System.Collections.Generic;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Companies
{
    public class Company:ICompany
    {
        public Company(string name, string registrationNumber)
        {
            Name = name;
            RegistrationNumber = registrationNumber;
        }
        public string Name { get; }
        public string RegistrationNumber { get; }
        public ICollection<IFurniture> Furnitures { get; }
        public void Add(IFurniture furniture)
        {
            throw new System.NotImplementedException();
            //) should be ordered by price then by model
        }

        public void Remove(IFurniture furniture)
        {
            throw new System.NotImplementedException();
        }

        public IFurniture Find(string model)
        {
            throw new System.NotImplementedException();
        }

        public string Catalog()
        {
            throw new System.NotImplementedException();
            //if.Empty : no furniture added, print “no furnitures”
            //else if.One : has 1 piece of furniture, print “1 furniture”
                //and show its information on a separate line
            //else print.ToString
        }

        public override string ToString()
        {
            return base.ToString();

            /*
             (company name) – (number of furniture/”no”) (“furniture”/”furnitures”)
(information about furniture)
(information about furniture)
(information about furniture)

             */

            /* STRING FORMAT:
            "{0} - {1} - {2} {3}",
this.Name,
this.RegistrationNumber,
this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
this.Furnitures.Count != 1 ? "furnitures" : "furniture"

            */
        }
    }
}