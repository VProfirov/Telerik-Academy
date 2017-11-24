using System;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Table:Furniture,ITable
    {
        public Table(string model, string material, decimal price, decimal height,decimal length,decimal width) : base(model, material, price, height)
        {
            if (length <= 0 || width <=0)
            {
                throw new ArgumentException("Neither length or width can be <= 0");
            }
            Length = length;
            Width = width;
            Area = Length * Width;
        }

        public decimal Length { get; }
        public decimal Width { get; }
        public decimal Area { get; }

        public override string ToString()
        {
            //NB! : The Type is either “Table“, or “Chair”, or “AdjustableChair” or “ConvertibleChair”.
            return base.ToString();
            /*
             "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height,  this.Length, this.Width, this.Area
             */
        }
    }
}