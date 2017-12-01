using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Chair:Furniture,IChair
    {
        public Chair(string model, string material, decimal price, decimal height, int numberOfLegs) : base(model, material, price, height)
        {
            NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs { get; }

        public override string ToString()
        {
            //NB: The Type is either “Table“, or “Chair”, or “AdjustableChair” or “ConvertibleChair”.
            return base.ToString();
            /*
             "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs
             */
        }
    }
}