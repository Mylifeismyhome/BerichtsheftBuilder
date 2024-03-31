using System;

namespace BerichtsheftBuilder.dto
{
    [Serializable()]
    public class TaskDto
    {
        protected DateUtils.CalendarWeek calendarWeek;
        public DateUtils.CalendarWeek CalendarWeek
        {
            get => calendarWeek;
        }

        protected string desc;
        public string Desc
        {
            get => desc;
        }

        protected bool isSchool;
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
