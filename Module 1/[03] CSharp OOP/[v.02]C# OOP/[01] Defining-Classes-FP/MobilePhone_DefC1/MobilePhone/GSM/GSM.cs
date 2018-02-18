using System;
using System.Text;

namespace MobilePhone.GSM
{
    public class GSM
    {
        private static GSM iPhone_4S = new GSM("iPhone4S", "Apple");

        private readonly string model;
        private readonly string manufacturer;
        private decimal? price;
        private string owner;
        private readonly Battery batteryCharacteristics;
        private readonly Display displayCharacteristics;

        public GSM(string model, string manufacturer,
            decimal? price = null, string owner = null,
            Battery battery = null, Display display = null)
        {
            this.model = !string.IsNullOrEmpty(model)
                ? model
                : throw new ArgumentException("Model can't be null or empty");
            this.manufacturer = !string.IsNullOrEmpty(manufacturer)
                ? model
                : throw new ArgumentException("Manufacturer can't be null or empty");
            this.price = price;
            this.owner = owner;
            this.batteryCharacteristics = battery;
            this.displayCharacteristics = display;
            //TODO: Characteristic tuple/type for the values
        }

        public static GSM iPhone4S => iPhone_4S;
        public string Model => this.model;
        public string Manufacturer => this.manufacturer;

        public decimal? Price
        {
            get => this.price;
            set => this.price = (value == null || value >= 0)
                ? value
                : throw new ArgumentException("Price must be 0, bigger or not defined");
        }

        public string Owner
        {
            get => this.owner;
            set => this.owner = value;
            // verification?
        }

        public Battery BatteryCharacteristics => this.batteryCharacteristics;
        public Display DisplayCharacteristics => this.displayCharacteristics;

        public string DeviceInformation()
        {
            return $"GSM Specifications: " +
                   this.ToString();
        }

        public override string ToString()
        {
            //TODO: Better concatenation for large datasets
            var sb = new StringBuilder();
            sb.AppendLine($"Model: {model}");
            sb.AppendLine($"Manufacturer: {manufacturer}");
            sb.AppendLine($"Price: {price}");
            sb.AppendLine($"Owner: {owner}");
            sb.AppendLine($"Battery characteristics: {batteryCharacteristics}");
            sb.AppendLine($"Display characteristics: {displayCharacteristics}");
            return sb.ToString();
        }

        #region calls

        public void AddCalls()
        {
        }

        public void DeleteCalls()
        {
        }

        public void ClearCallHistory()
        {
        }

        public void CallPrice()
        {
            /*
             * Add a method that calculates the total price of the calls in the call history.
             * Assume the price per minute is fixed and is provided as a parameter.
             */
        }

        #endregion
    }
}