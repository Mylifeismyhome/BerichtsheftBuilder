using System;
using System.Globalization;

namespace BerichtsheftBuilder
{
    public class DateUtils
    {
        [Serializable()]
        public class CalendarWeek
        {
            private int year;
            public int Year
            {
                get => year;
                set => year = value;
            }

            private int week;
            public int Week
            {
                get => week;
                set => week = value;
            }

            public bool Match(CalendarWeek other)
            {
                return (week == other.week && year == other.year);
            }

            public override string ToString()
            {
                return $"Woche: {Week}, Jahr: {Year}";
            }
        }

        public static CalendarWeek GetCalendarWeek(DateTime date, string format = "de-DE")
        {
            CultureInfo ci = new CultureInfo(format);
            Calendar calendar = ci.Calendar;
            int weekOfYear = calendar.GetWeekOfYear(date, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek);
            return new CalendarWeek { Year = date.Year, Week = weekOfYear };
        }
    }
}
