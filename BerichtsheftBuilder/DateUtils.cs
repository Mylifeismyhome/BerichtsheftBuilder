using System;
using System.Globalization;
using static System.Windows.Forms.DataFormats;

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

            [NonSerialized]
            private CultureInfo cultureInfo;
            public CultureInfo CultureInfo
            {
                get => cultureInfo;
                set => cultureInfo = value;
            }

            private DateTime weekStartDate;
            public DateTime WeekStartDate
            {
                get => weekStartDate;
                set => weekStartDate = value;
            }

            private DateTime weekEndDate;
            public DateTime WeekEndDate
            {
                get => weekEndDate;
                set => weekEndDate = value;
            }

            public CalendarWeek(DateTime date, string format)
            {
                CultureInfo = new CultureInfo(format);

                Year = date.Year;
                week = CultureInfo.Calendar.GetWeekOfYear(date, CultureInfo.DateTimeFormat.CalendarWeekRule, CultureInfo.DateTimeFormat.FirstDayOfWeek);

                weekStartDate = date.AddDays(-(int)date.DayOfWeek + (int)DayOfWeek.Monday);
                weekEndDate = weekStartDate.AddDays(4);
            }

            public bool Match(CalendarWeek other)
            {
                return (week == other.week && year == other.year);
            }

            public override string ToString()
            {
                return $"Woche: {Week}, Jahr: {Year}";
            }

            public string ToLongString()
            {
                return $"Woche: {Week}, Jahr: {Year}, Startdatum: {StartDateAsString()}, Enddatum: {EndDateAsString()}";
            }

            public string StartDateAsString()
            {
                return weekStartDate.ToString("dd.MM.yyyy", cultureInfo);
            }

            public string EndDateAsString()
            {
                return weekEndDate.ToString("dd.MM.yyyy", cultureInfo);
            }
        }

        public static CalendarWeek GetCalendarWeek(DateTime date, string format = "de-DE")
        {
            return new CalendarWeek(date, format);
        }
    }
}
