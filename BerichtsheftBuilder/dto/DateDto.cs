using System;
using System.Globalization;
using System.Text.Json.Serialization;

namespace BerichtsheftBuilder.Dto
{
    [Serializable()]
    public class DateDto
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

        [JsonIgnore]
        private CultureInfo cultureInfo;

        [JsonIgnore]
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

        public DateDto(DateTime date, string format)
        {
            CultureInfo = new CultureInfo(format);

            Year = date.Year;
            week = CultureInfo.Calendar.GetWeekOfYear(date, CultureInfo.DateTimeFormat.CalendarWeekRule, CultureInfo.DateTimeFormat.FirstDayOfWeek);

            weekStartDate = date.AddDays(-(int)date.DayOfWeek + (int)DayOfWeek.Monday);
            weekEndDate = weekStartDate.AddDays(4);
        }

        [JsonConstructor]
        public DateDto(int year, int week, DateTime weekStartDate, DateTime weekEndDate)
        {
            this.year = year;
            this.week = week;
            this.weekStartDate = weekStartDate;
            this.weekEndDate = weekEndDate;
        }

        public bool Match(DateDto other)
        {
            return week == other.week && year == other.year;
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

        public static DateDto GetCalendarWeek(DateTime date, string format = "de-DE")
        {
            return new DateDto(date, format);
        }
    }
}
