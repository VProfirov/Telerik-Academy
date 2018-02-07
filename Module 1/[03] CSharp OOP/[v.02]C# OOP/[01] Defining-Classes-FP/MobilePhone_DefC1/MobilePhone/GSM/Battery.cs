using System;

namespace MobilePhone.GSM
{
    public class Battery
    {
        private readonly string model;
        private TimeSpan? hours_idle;
        private TimeSpan? hours_talk;
        private readonly Battery_Type? batteryType;

        public Battery(string model = null, Battery_Type? batteryType = null, TimeSpan? hoursIdle = null,
            TimeSpan? hoursTalk = null)
        {
            this.model = model;
            this.batteryType = batteryType;
            this.hours_idle = hoursIdle;
            this.hours_talk = hoursTalk;
        }

        public enum Battery_Type
        {
            Li_Ion,
            NiMH,
            NiCd
        }

        public string Model => this.model;
        public Battery_Type? BatteryType => this.batteryType;

        public TimeSpan? HoursIdle
        {
            get => this.hours_idle;
            set => this.hours_idle = (value == null || value >= default(TimeSpan))
                ? value
                : throw new ArgumentException(
                    "The value for the HoursIdle of this battery is neither TimeSpan value or null");
        }

        public TimeSpan? HoursTalk
        {
            get => this.hours_talk;
            set => this.hours_talk = (value == null || value >= default(TimeSpan))
                ? value
                : throw new ArgumentException(
                    "The value for the HoursTalk of this battery is neither TimeSpan value or null");
        }
    }
}