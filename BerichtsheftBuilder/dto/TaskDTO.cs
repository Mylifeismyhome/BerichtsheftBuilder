using System;

namespace BerichtsheftBuilder.dto
{
    [Serializable()]
    public class TaskDTO 
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

        protected TaskDTO()
        {
            calendarWeek = null;
            desc = "";
            isSchool = false;
        }

        public static TaskDTO valueOf(DateUtils.CalendarWeek calendarWeek, string desc, bool isSchool)
        {
            TaskDTO dto = new TaskDTO();
            dto.calendarWeek = calendarWeek;
            dto.desc = desc;
            dto.isSchool = isSchool;
            return dto;
        }
    }
}
