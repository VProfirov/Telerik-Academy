using System;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public abstract class Furniture:IFurniture
    {
        private decimal _price;

        protected Furniture(string model,string material,decimal price,decimal height)
        {
            if (string.IsNullOrEmpty(model) || model.Length < 3)
            {
                throw new ArgumentException("Model cannot be empty, null or with less than 3 symbols.");
            }
            if (price <= 0)
            {
                throw new ArgumentException("Price cannot be less or equal to $0.00.");
            }
            if (height <= 0)
            {
                throw new ArgumentException("Height cannot be less or equal to 0.00 m.");
            }
            if (!Enum.IsDefined(typeof(MaterialType), material))
            {
                throw new ArgumentException("No such material!");
            }
            Model = model;
            Material = material;
            Price = price;
            Height = height;
        }
        public string Model { get; }
        public string Material { get; }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be less or equal to $0.00.");
                }
                _price = value;
            }
        }
        public decimal Height { get; }
    }
}