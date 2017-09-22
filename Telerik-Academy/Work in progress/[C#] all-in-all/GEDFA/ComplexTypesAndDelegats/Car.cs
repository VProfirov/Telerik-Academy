using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTypesAndDelegats
{
    class Car
    {
        public Car(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public string iModel()
        {
            return $"The Model is : {this.Model}";
        }

        public string iManufacturer()
        {
            return $"The Manufac is : {this.Manufacturer}";
        }

        public void ModelChange()
        {
            this.Model = "E3";
            this.Manufacturer = "Tesla";
        }
    }
}
