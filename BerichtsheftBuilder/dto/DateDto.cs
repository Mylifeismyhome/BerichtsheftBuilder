using BerichtsheftBuilder.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Text.Json.Serialization;

namespace BerichtsheftBuilder.Dto
{
    [Serializable()]
    public class DateDto
    {
        [JsonIgnore]
        private CultureInfoService cultureInfoService = Program.ServiceProvider.GetService<CultureInfoService>();

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

        public DateDto(DateTime date)
        {
            Year = date.Year;
            week = cultureInfoService.CultureInfo.Calendar.GetWeekOfYear(date, cultureInfoService.CultureInfo.DateTimeFormat.CalendarWeekRule, cultureInfoService.CultureInfo.DateTimeFormat.FirstDayOfWeek);

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
            return $"Woche vom {StartDateAsString()} bis {EndDateAsString()} (Kalenderwoche {week}, Jahr {year})";
        }

        public string StartDateAsString()
        {
            return cultureInfoService.dateFormat(weekStartDate);
        }

        public string EndDateAsString()
        {
            return cultureInfoService.dateFormat(weekEndDate);
        }

        public static DateDto GetCalendarWeek(DateTime date)
        {
            return new DateDto(date);
        }
    }
}