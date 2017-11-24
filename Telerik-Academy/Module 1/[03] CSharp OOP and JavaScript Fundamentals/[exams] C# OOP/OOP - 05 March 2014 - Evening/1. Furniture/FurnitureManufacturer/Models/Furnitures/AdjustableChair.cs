using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class AdjustableChair:Chair,IAdjustableChair
    {
        private decimal _height;
        public AdjustableChair(string model, string material, decimal price, decimal height, int numberOfLegs) : base(model, material, price, height, numberOfLegs)
        {
        }

        public void SetHeight(decimal height)
        {
            _height = height;
        }

        public new decimal Height => _height;
    }
}