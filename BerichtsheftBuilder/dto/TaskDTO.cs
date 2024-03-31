using System;

namespace BerichtsheftBuilder.dto
{
    [Serializable()]
    public class TaskDto
    {
        private DateUtils.CalendarWeek calendarWeek;
        public DateUtils.CalendarWeek CalendarWeek
        {
            get => calendarWeek;
        }

        private string desc;
        public string Desc
        {
            get => desc;
        }

        private bool isSchool;
        public bool IsSchool
        {
            get => isSchool;
        }

        protected TaskDto()
        {
            calendarWeek = null;
            desc = "";
            isSchool = false;
        }

        public static TaskDto valueOf(DateUtils.CalendarWeek calendarWeek, string desc, bool isSchool)
        {
            TaskDto dto = new TaskDto();
            dto.calendarWeek = calendarWeek;
            dto.desc = desc;
            dto.isSchool = isSchool;
            return dto;
        }
    }
}
