using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new Time();
            GetTime(time);            

            Console.WriteLine($"Sharp corner between arrows: {time.GetCorner()}\u00B0");
        }

        private static void GetTime(Time time)
        {           
            string hourString = string.Empty;
            Console.WriteLine("Please enter the hours");
            while (string.IsNullOrWhiteSpace(hourString))
            {
                hourString = Console.ReadLine();
                hourString = time.ValidateHoursInput(hourString);
            }

            string minuteString = string.Empty;
            Console.WriteLine("Please enter the minutes");
            while (string.IsNullOrWhiteSpace(minuteString))
            {
                minuteString = Console.ReadLine();
                minuteString = time.ValidateMinutesInput(minuteString);
            }
        }


        //private static string ValidateMinutesInput(Time time, string minuteString)
        //{
        //    try
        //    {
        //        int minute = int.Parse(minuteString);
        //        if (minute < 0 || minute >= 60) throw new ArgumentOutOfRangeException();
        //        time.Minute = minute;
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Minute must be whole numeric value!\nTry again");
        //        minuteString = string.Empty;
        //    }
        //    catch (ArgumentOutOfRangeException)
        //    {
        //        Console.WriteLine("Minutes must be in between 0 and 59!\nTry again");
        //        minuteString = string.Empty;
        //    }

        //    return minuteString;
        //}


        //private static string ValidateHoursInput(Time time, string hourString)
        //{
        //    try
        //    {
        //        int hour = int.Parse(hourString);
        //        if (hour < 0 || hour > 24) throw new ArgumentOutOfRangeException();
        //        time.Hour = hour;
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Hours must be whole numeric value!\nTry again");
        //        hourString = string.Empty;
        //    }
        //    catch (ArgumentOutOfRangeException)
        //    {
        //        Console.WriteLine("Hours must be in 24h format!\nTry again");
        //        hourString = string.Empty;
        //    }

        //    return hourString;
        //}
    }
}


//paversti 12-23h i 0-11
