namespace Telenor.Factory.Functionality
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;

    class Call
    {
        public DateTime Date { get; private set; } = DateTime.Today;

        public DateTime Time { get; private set; } = DateTime.UtcNow;

        public string PhoneNumber { get; private set; } = "undefined";
        public TimeSpan DurationInSeconds { get; private set; } = TimeSpan.FromSeconds(0);

        public Call(string phoneNumber)
        {
            MadeCall(phoneNumber);
        }
        public void MadeCall(string phoneNumber)
        {
            var isMatch = Regex
                .Match(phoneNumber, @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$");
            try
            {
                if (isMatch.Success)
                {
                    this.PhoneNumber = phoneNumber;
                    this.DurationInSeconds = this.DurationSimulator();
                }
            }
            catch (Exception e)
            {

                throw new ArgumentException("Wrong number format - GSM system bug\r\n", e);
            }
        }

        private TimeSpan DurationSimulator()
        {
            return TimeSpan.FromSeconds(125);
        }
    }
}
