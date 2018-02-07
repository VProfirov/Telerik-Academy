using System;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class ConvertibleChair:Chair,IConvertibleChair
    {
        private decimal _heightConvertedState = 0.10m;
        private decimal _heightNormalState;
        private decimal _height;
        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs) : base(model, material, price, height, numberOfLegs)
        {
            _heightNormalState = Height;
        }

        public new decimal Height => _height;
        public bool IsConverted { get; }
        public void Convert()
        {
            _height = (IsConverted) ? _heightConvertedState : _heightNormalState;
        }

        public override string ToString()
        {
            //NB: The Type is either “Table“, or “Chair”, or “AdjustableChair” or “ConvertibleChair”.
            return base.ToString();
            /*
             "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs, this.IsConverted ? "Converted" : "Normal"
             */
        }
    }
}