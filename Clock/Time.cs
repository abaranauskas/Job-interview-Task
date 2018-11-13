using System;

namespace Clock
{
    public class Time
    {
        public Time()
        {
                
        }

        public double GetCorner()
        {
            double hoursCorner = (360 / 12 * Hour) + ((360 / 60 * Minute) / 12);
            double minuteCorner = 360 / 60 * Minute;

            var corner = Math.Abs(hoursCorner - minuteCorner);

            return (corner <= 180) ? corner : 360 - corner;           
        }

        public string ValidateHoursInput(string hourString)
        {
            try
            {
                int hour = int.Parse(hourString);
                if (hour < 0 || hour > 24) throw new ArgumentOutOfRangeException();
                this.Hour = hour;
            }
            catch (FormatException)
            {
                Console.WriteLine("Hours must be whole numeric value!\nTry again");
                hourString = string.Empty;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Hours must be in 24h format!\nTry again");
                hourString = string.Empty;
            }

            return hourString;
        }

        public string ValidateMinutesInput(string minuteString)
        {
            try
            {
                int minute = int.Parse(minuteString);
                if (minute < 0 || minute >= 60) throw new ArgumentOutOfRangeException();
                Minute = minute;
            }
            catch (FormatException)
            {
                Console.WriteLine("Minute must be whole numeric value!\nTry again");
                minuteString = string.Empty;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Minutes must be in between 0 and 59!\nTry again");
                minuteString = string.Empty;
            }

            return minuteString;
        }

        private double GetHoursInTwelveFormat(double _hour)
        {
            var hour = (int)_hour;

            if (hour > 12)
            {
                int j = 0;
                for (int i = 11; i < hour; i++)
                {
                    _hour = j++;
                }
            }

            return _hour;
        }


        private double _hour;
        public double Hour
        {
            get { return GetHoursInTwelveFormat(_hour); }
            set { _hour = value; }
        }

        public double Minute { get; set; }
    }
}
